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
    public partial class StudentForm : Form
    {
        CollegeEntities collegeEntities;
        Student selectedStudent;
        public StudentForm()
        {
            collegeEntities = new CollegeEntities();
            selectedStudent = new Student();
            InitializeComponent();
            UpdateBoxes();
        }

        private void UpdateBoxes()
        {
            selectedStudent = studentListBox.SelectedItem as Student;
            if (selectedStudent != null)
            {
                //idBox.Text = selectedStudent.Id.ToString();
                nameBox.Text = selectedStudent.Name;
                umidBox.Text = selectedStudent.UMID;
                creditsBox.Text = selectedStudent.Credits_Earned.ToString();
                majorIdBox.Text = selectedStudent.Major_Id.ToString();
            }
            studentListBox.Items.Clear();
            foreach (var student in collegeEntities.Students)
            {
                studentListBox.Items.Add(student);
            }
        }

        private int EmptyBox()
        {
            int emptyBox = 0;
            if (nameBox.Text == "")
            {
                emptyBox = 2;
            }
            else if (umidBox.Text == "")
            {
                emptyBox = 3;
            }
            else if (creditsBox.Text == "")
            {
                emptyBox = 4;
            }
            else if (majorIdBox.Text == "")
            {
                emptyBox = 5;
            }
            return emptyBox;
        }

        private int ValidKey()
        {
            int validKey = 0;
            if (collegeEntities.Majors.Find(Convert.ToInt32(majorIdBox.Text)) == null)
            {
                validKey = 1;
            }
            return validKey;
        }

        private void studentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBoxes();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0)
            {
                Student addStudent = new Student {
                    Name = nameBox.Text,
                    UMID = umidBox.Text,
                    Credits_Earned = Convert.ToInt32(creditsBox.Text),
                    Major_Id = Convert.ToInt32(majorIdBox.Text),
                };
                collegeEntities.Students.Add(addStudent);
                collegeEntities.SaveChanges();
                UpdateBoxes();
            }
            else
            {
                switch (EmptyBox())
                {
                    //case 1: idBox.Text = "Error! ID empty"; break;
                    case 2: nameBox.Text = "Error! Name empty"; break;
                    case 3: umidBox.Text = "Error! UMID empty"; break;
                    case 4: creditsBox.Text = "Error! Credits empty"; break;
                    case 5: majorIdBox.Text = "Error! Major ID empty"; break;
                }
            }
        }

        private void updateStudent_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0)
            {
                Student updateStudent = selectedStudent;//studentListBox.SelectedItem as Student;//collegeEntities.Students.Find(Convert.ToInt32(idBox.Text));
                if (updateStudent != null) {
                    updateStudent.Name = nameBox.Text;
                    updateStudent.UMID = umidBox.Text;
                    updateStudent.Credits_Earned = Convert.ToInt32(creditsBox.Text);
                    updateStudent.Major_Id = Convert.ToInt32(majorIdBox.Text);

                    collegeEntities.SaveChanges();
                    UpdateBoxes();
                }
            } else {
                switch (EmptyBox()) {
                    //case 1: idBox.Text = "Error! ID empty"; break;
                    case 2: nameBox.Text = "Error! Name empty"; break;
                    case 3: umidBox.Text = "Error! UMID empty"; break;
                    case 4: creditsBox.Text = "Error! Credits empty"; break;
                    case 5: majorIdBox.Text = "Error! Major ID empty"; break;
                }
            }
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            Student deleteStudent = selectedStudent;
            if (deleteStudent != null)
            {
                collegeEntities.Students.Remove(deleteStudent);
            }
            collegeEntities.SaveChanges();
            UpdateBoxes();
        }

        private void studentFormLookupBox_TextChanged(object sender, EventArgs e)
        {
            updateSearch(studentFormLookupBox.Text);
        }
        public void updateSearch(string text)
        {
            studentListBox.Items.Clear();
            foreach (var student in collegeEntities.Students/*.Where(c => c.Sections.Count > 0)*/)  //very useful clause for searching stuff with filters foreach (var course in collegeEntities.Courses.Where(c => c.Enrollment.Count < 30
            {
                if (text == "")//used to make sure no classes are showing up when no text is in the search bar 
                {
                    break;
                }
                if (text != "" &&
                    !student.Major.Name.StartsWith(text)) //start from here when you get back to filtering 
                {
                    continue;

                }



                studentListBox.Items.Add(student);//need to figure out way to get text from items to pull into the text boxes at the bottom, talk to jason about this later
                
                
                
                
            }
        }
    }
}
