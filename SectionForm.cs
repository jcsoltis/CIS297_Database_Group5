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
            UpdateBoxes();
        }

        private void UpdateBoxes()
        {
            selectedSection = sectionListBox.SelectedItem as Section;
            if (selectedSection != null)
            {
                idBox.Text = selectedSection.Id.ToString();
                courseIdBox.Text = selectedSection.Course_Id.ToString();
                instructorIdBox.Text = selectedSection.Instructor_Id.ToString();
                daysBox.Text = selectedSection.Days;
                timeBox.Text = selectedSection.Time;
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
            if (idBox.Text == "")
            {
                emptyBox = 1;
            }
            else if (courseIdBox.Text == "")
            {
                emptyBox = 2;
            }
            else if (instructorIdBox.Text == "")
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
            if (collegeEntities.Courses.Find(Convert.ToInt32(courseIdBox.Text)) == null)
            {
                validKey = 1;
            }
            else if (collegeEntities.Instructors.Find(Convert.ToInt32(instructorIdBox.Text)) == null)
            {
                validKey = 2;
            }
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
                bool idEmpty = true;
                foreach (var section in collegeEntities.Sections)
                {
                    if (section.Id == Convert.ToInt32(idBox.Text))
                    {
                        idEmpty = false;
                    }
                }
                if (idEmpty)
                {
                    if (ValidKey() == 0)
                    {
                        Section addSection = new Section
                        {
                            Id = Convert.ToInt32(idBox.Text),
                            Course_Id = Convert.ToInt32(courseIdBox.Text),
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
                        switch (ValidKey())
                        {
                            case 1: courseIdBox.Text = "Error! Course ID nonexistent"; break;
                            case 2: instructorIdBox.Text = "Error! Instructor ID nonexistent"; break;
                        }
                    }
                }
                else
                {
                    idBox.Text = "Error! ID already exists";
                }
            }
            else
            {
                switch (EmptyBox())
                {
                    case 1: idBox.Text = "Error! ID empty"; break;
                    case 2: courseIdBox.Text = "Error! Course ID empty"; break;
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
                Section updateSection = collegeEntities.Sections.Find(Convert.ToInt32(idBox.Text));
                if (updateSection != null)
                {
                    if (ValidKey() == 0)
                    {
                        updateSection.Course_Id = Convert.ToInt32(courseIdBox.Text);
                        updateSection.Instructor_Id = Convert.ToInt32(instructorIdBox.Text);
                        updateSection.Days = daysBox.Text;
                        updateSection.Time = timeBox.Text;
                    }
                    else
                    {
                        switch (ValidKey())
                        {
                            case 1: courseIdBox.Text = "Error! Course ID nonexistent"; break;
                            case 2: instructorIdBox.Text = "Error! Instructor ID nonexistent"; break;
                        }
                    }
                }
                else
                {
                    idBox.Text = "ID does not exist to update";
                }

                collegeEntities.SaveChanges();
                UpdateBoxes();
            }
            else
            {
                switch (EmptyBox())
                {
                    case 1: idBox.Text = "Error! ID empty"; break;
                    case 2: courseIdBox.Text = "Error! Course ID empty"; break;
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
    }
}
