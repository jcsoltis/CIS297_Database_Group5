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
    public partial class EnrollmentForm : Form
    {
        CollegeEntities collegeEntities;
        Enrollment selectedEnrollment;
        public EnrollmentForm()
        {
            collegeEntities = new CollegeEntities();
            selectedEnrollment = new Enrollment();
            InitializeComponent();
            UpdateBoxes();
        }

        private void UpdateBoxes()
        {
            selectedEnrollment = enrollmentListBox.SelectedItem as Enrollment;
            if (selectedEnrollment != null)
            {
                idBox.Text = selectedEnrollment.Id.ToString();
                studentIdBox.Text = selectedEnrollment.Student_Id.ToString();
                sectionIdBox.Text = selectedEnrollment.Section_Id.ToString();
                gradeBox.Text = selectedEnrollment.Grade.ToString();
            }
            enrollmentListBox.Items.Clear();
            foreach (var enrollment in collegeEntities.Enrollments)
            {
                enrollmentListBox.Items.Add(enrollment);
            }
        }

        private int EmptyBox()
        {
            int emptyBox = 0;
            if (idBox.Text == "")
            {
                emptyBox = 1;
            }
            else if (studentIdBox.Text == "")
            {
                emptyBox = 2;
            }
            else if (sectionIdBox.Text == "")
            {
                emptyBox = 3;
            }
            else if (gradeBox.Text == "")
            {
                emptyBox = 4;
            }
            return emptyBox;
        }

        private int ValidKey()
        {
            int validKey = 0;
            if (collegeEntities.Students.Find(Convert.ToInt32(studentIdBox.Text)) == null)
            {
                validKey = 1;
            }
            else if (collegeEntities.Sections.Find(Convert.ToInt32(sectionIdBox.Text)) == null)
            {
                validKey = 2;
            }
            return validKey;
        }

        private void enrollmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBoxes();
        }

        private void addEnrollment_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0)
            {
                bool idEmpty = true;
                foreach (var enrollment in collegeEntities.Enrollments)
                {
                    if (enrollment.Id == Convert.ToInt32(idBox.Text))
                    {
                        idEmpty = false;
                    }
                }
                if (idEmpty)
                {
                    if (ValidKey() == 0)
                    {
                        Enrollment addEnrollment = new Enrollment
                        {
                            Id = Convert.ToInt32(idBox.Text),
                            Student_Id = Convert.ToInt32(studentIdBox.Text),
                            Section_Id = Convert.ToInt32(sectionIdBox.Text),
                            Grade = Convert.ToDouble(gradeBox.Text),
                        };
                        collegeEntities.Enrollments.Add(addEnrollment);
                        collegeEntities.SaveChanges();
                        UpdateBoxes();
                    }
                    else
                    {
                        switch (ValidKey())
                        {
                            case 1: studentIdBox.Text = "Error! Student ID nonexistent"; break;
                            case 2: sectionIdBox.Text = "Error! Section ID nonexistent"; break;
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
                    case 2: studentIdBox.Text = "Error! Student ID empty"; break;
                    case 3: sectionIdBox.Text = "Error! Section ID empty"; break;
                    case 4: gradeBox.Text = "Error! Grade empty"; break;
                }
            }
        }

        private void updateEnrollment_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0)
            {
                Enrollment updateEnrollment = collegeEntities.Enrollments.Find(Convert.ToInt32(idBox.Text));
                if (updateEnrollment != null)
                {
                    if (ValidKey() == 0)
                    {
                        updateEnrollment.Student_Id = Convert.ToInt32(studentIdBox.Text);
                        updateEnrollment.Section_Id = Convert.ToInt32(sectionIdBox.Text);
                        updateEnrollment.Grade = Convert.ToDouble(gradeBox.Text);
                    }
                    else
                    {
                        switch (ValidKey())
                        {
                            case 1: studentIdBox.Text = "Error! Student ID nonexistent"; break;
                            case 2: sectionIdBox.Text = "Error! Section ID nonexistent"; break;
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
                    case 2: studentIdBox.Text = "Error! Student ID empty"; break;
                    case 3: sectionIdBox.Text = "Error! Section ID empty"; break;
                    case 4: gradeBox.Text = "Error! Grade empty"; break;
                }
            }
        }

        private void deleteEnrollment_Click(object sender, EventArgs e)
        {
            Enrollment deleteEnrollment = selectedEnrollment;
            if (deleteEnrollment != null)
            {
                collegeEntities.Enrollments.Remove(deleteEnrollment);
            }
            collegeEntities.SaveChanges();
            UpdateBoxes();
        }

        private void enrollmentFormLookupBox_TextChanged(object sender, EventArgs e)
        {
            //updateSearch(enrollmentFormLookupBox.Text);
        }
      /*  public void updateSearch(string text)  //whole function needs to be worked on with group
        {
            enrollmentListBox.Items.Clear();
            foreach (var enrollment in collegeEntities.Enrollments/*.Where(c => c.Sections.Count > 0))  //very useful clause for searching stuff with filters foreach (var course in collegeEntities.Courses.Where(c => c.Enrollment.Count < 30
            {
                if (text == "")//used to make sure no classes are showing up when no text is in the search bar 
                {
                    break;
                }
                if (text != "" &&
                    !enrollment.Student.Name.StartsWith(text)) //start from here when you get back to filtering 
                {
                    continue;

                }



                enrollmentListBox.Items.Add(enrollment);
                foreach (var field in student)                                                            
                {
                    enrollmentListBox.Items.Add($"{student.UMID}{student.Credits_Earned}{Environment.NewLine}");//figure out how to implement major in here
                }
            
            
            }
        }*/
    }
}
