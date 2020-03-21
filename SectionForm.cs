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
            instructorDropdown.DataSource = collegeEntities.Instructors.ToList();
            sectionListBox.DataSource = collegeEntities.Sections.ToList();
            if (collegeEntities.Sections.ToList().Count > 0) 
                sectionListBox.SelectedItem = collegeEntities.Sections.ToList()[0];
            
            UpdateBoxes();
        }

        private void UpdateBoxes()
        {
            selectedSection = sectionListBox.SelectedItem as Section;
            if (selectedSection != null)
            {
                courseDropdown.SelectedIndex = selectedSection.Course_Id-1;
                instructorDropdown.SelectedIndex = selectedSection.Instructor_Id-1;
                daysBox.Text = selectedSection.Days;
                timeBox.Text = selectedSection.Time;
                semesterTextBox.Text = selectedSection.Semester;
            }
        }

        private int EmptyBox()
        {
            int emptyBox = 0;
            if (daysBox.Text == "")
            {
                emptyBox = 4;
            }
            else if (timeBox.Text == "")
            {
                emptyBox = 5;
            }
            else if (semesterTextBox.Text == "") {
                emptyBox = 6;
            }
            return emptyBox;
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
                    Course_Id = (courseDropdown.SelectedItem as Course).Id,
                    Instructor_Id = (instructorDropdown.SelectedItem as Instructor).Id,
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
                    case 4: daysBox.Text = "Error! Days empty"; break;
                    case 5: timeBox.Text = "Error! Time empty"; break;
                    case 6: semesterTextBox.Text = "Error! Semester empty"; break;
                }
            }
        }

        private void updateSection_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0)
            {
                Section updateSection = selectedSection;
                if (updateSection != null) {
                    updateSection.Course_Id = (courseDropdown.SelectedItem as Course).Id;
                    updateSection.Instructor_Id = (instructorDropdown.SelectedItem as Instructor).Id;
                    updateSection.Days = daysBox.Text;
                    updateSection.Time = timeBox.Text;
                    collegeEntities.SaveChanges();
                    UpdateBoxes();
                }
            }
            else
            {
                switch (EmptyBox())
                {
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
            bool emptySemester = sectionFormLookupBox.Text == "";
            bool emptyFaculty = sectionFormLookupFacultyBox.Text == "";
            if (!emptySemester || !emptyFaculty) {
                var newList = collegeEntities.Sections.
                Where(c => c.Semester.ToUpper().StartsWith(sectionFormLookupBox.Text.ToUpper()) &&
                c.Instructor.Name.Contains(sectionFormLookupFacultyBox.Text)).ToList();
                sectionListBox.DataSource = newList;
                if (newList.Count > 0)
                    sectionListBox.SelectedItem = newList[0];
            } else {
                sectionListBox.DataSource = collegeEntities.Sections.ToList();
                if (collegeEntities.Sections.ToList().Count > 0)
                    sectionListBox.SelectedItem = collegeEntities.Sections.ToList()[0];
            }
            UpdateBoxes();
        }
    }
}
