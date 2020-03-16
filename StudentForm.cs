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
                idBox.Text = selectedStudent.Id.ToString();
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
            if (idBox.Text == "")
            {
                emptyBox = 1;
            }
            else if (nameBox.Text == "")
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
                bool idEmpty = true;
                foreach (var student in collegeEntities.Students)
                {
                    if (student.Id == Convert.ToInt32(idBox.Text))
                    {
                        idEmpty = false;
                    }
                }
                if (idEmpty)
                {
                    if (ValidKey() == 0)
                    {
                        Student addStudent = new Student
                        {
                            Id = Convert.ToInt32(idBox.Text),
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
                        switch (ValidKey())
                        {
                            case 1: majorIdBox.Text = "Error! Major ID nonexistent"; break;
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
                Student updateStudent = collegeEntities.Students.Find(Convert.ToInt32(idBox.Text));
                if (updateStudent != null)
                {
                    if (ValidKey() == 0)
                    {
                        updateStudent.Name = nameBox.Text;
                        updateStudent.UMID = umidBox.Text;
                        updateStudent.Credits_Earned = Convert.ToInt32(creditsBox.Text);
                        updateStudent.Major_Id = Convert.ToInt32(majorIdBox.Text);
                    }
                    else
                    {
                        switch (ValidKey())
                        {
                            case 1: majorIdBox.Text = "Error! Major ID nonexistent"; break;
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
    }
}
