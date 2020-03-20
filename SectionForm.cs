using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SectionForm : Form
    {
        CollegeEntities collegeEntities;
        Section selectedSection;
        public SectionForm()
        {
            collegeEntities = new CollegeEntities();
            selectedSection = new Section();
            InitializeComponent();
            courseDropdown.DataSource = collegeEntities.Courses.ToList();
            UpdateBoxes();
        }

        private void UpdateBoxes()
        {
            selectedSection = sectionListBox.SelectedItem as Section;
            if (selectedSection != null)
            {
                courseDropdown.SelectedIndex = selectedSection.Course_Id-1;
                instructorIdBox.Text = selectedSection.Instructor_Id.ToString();
                daysBox.Text = selectedSection.Days;
                timeBox.Text = selectedSection.Time;
                semesterTextBox.Text = selectedSection.Semester;
            }
            sectionListBox.Items.Clear();
            foreach (var section in collegeEntities.Sections)
            {
                sectionListBox.Items.Add(section);
            }
        }

        private int EmptyBox()
        {
            int emptyBox = 0;
            if (instructorIdBox.Text == "")
            {
                emptyBox = 3;
            }
            else if (daysBox.Text == "")
            {
                emptyBox = 4;
            }
            else if (timeBox.Text == "")
            {
                emptyBox = 5;
            }
            return emptyBox;
        }

        private int ValidKey()
        {
            int validKey = 0;
            /*if (collegeEntities.Courses.Find(Convert.ToInt32(courseIdBox.Text)) == null)
            {
                validKey = 1;
            }
            else if (collegeEntities.Instructors.Find(Convert.ToInt32(instructorIdBox.Text)) == null)
            {
                validKey = 2;
            }*/
            return validKey;
        }

        private void sectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBoxes();
        }

        private void addSection_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0)
            {
                Section addSection = new Section {
                    Course_Id = (courseDropdown.SelectedItem as Course).Id,//courseIdBox.Text),
                    Instructor_Id = Convert.ToInt32(instructorIdBox.Text),
                    Days = daysBox.Text,
                    Time = timeBox.Text,
                };
                collegeEntities.Sections.Add(addSection);
                collegeEntities.SaveChanges();
                UpdateBoxes();
            }
            else
            {
                switch (EmptyBox())
                {
                    case 3: instructorIdBox.Text = "Error! Instructor ID empty"; break;
                    case 4: daysBox.Text = "Error! Days empty"; break;
                    case 5: timeBox.Text = "Error! Time empty"; break;
                }
            }
        }

        private void updateSection_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0)
            {
                Section updateSection = selectedSection;//sectionListBox.SelectedItem as Section;//collegeEntities.Sections.Find(Convert.ToInt32(idBox.Text));
                if (updateSection != null)
                {
                    if (ValidKey() == 0)
                    {
                        updateSection.Course_Id =  (courseDropdown.SelectedItem as Course).Id;
                        updateSection.Instructor_Id = Convert.ToInt32(instructorIdBox.Text);
                        updateSection.Days = daysBox.Text;
                        updateSection.Time = timeBox.Text;
                    }
                    else
                    {
                        switch (ValidKey())
                        {
                            //case 1: courseIdBox.Text = "Error! Course ID nonexistent"; break;
                            case 2: instructorIdBox.Text = "Error! Instructor ID nonexistent"; break;
                        }
                    }
                }

                collegeEntities.SaveChanges();
                UpdateBoxes();
            }
            else
            {
                switch (EmptyBox())
                {
                    //case 1: idBox.Text = "Error! ID empty"; break;
                    //case 2: courseIdBox.Text = "Error! Course ID empty"; break;
                    case 3: instructorIdBox.Text = "Error! Instructor ID empty"; break;
                    case 4: daysBox.Text = "Error! Days empty"; break;
                    case 5: timeBox.Text = "Error! Time empty"; break;
                }
            }
        }

        private void deleteSection_Click(object sender, EventArgs e)
        {
            Section deleteSection = selectedSection;
            if (deleteSection != null)
            {
                collegeEntities.Sections.Remove(deleteSection);
            }
            collegeEntities.SaveChanges();
            UpdateBoxes();
        }

        private void sectionFormLookupBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
