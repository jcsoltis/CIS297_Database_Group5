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
        List<Student> filteredList;
        public StudentForm()
        {
            collegeEntities = new CollegeEntities();
            selectedStudent = new Student();
            filteredList = new List<Student>();
            InitializeComponent();
            studentListBox.DataSource = collegeEntities.Students.ToList();
            majorDropdown.DataSource = collegeEntities.Majors.ToList();
            UpdateBoxes();
        }

        private void UpdateBoxes()
        {
            selectedStudent = studentListBox.SelectedItem as Student;
            if (selectedStudent != null)
            {
                nameBox.Text = selectedStudent.Name;
                umidBox.Text = selectedStudent.UMID;
                creditsBox.Text = selectedStudent.Credits_Earned.ToString();
                if (majorDropdown.Items.Count > 0)
                    majorDropdown.SelectedIndex = selectedStudent.Major_Id - 1;
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
            return emptyBox;
        }

        private void studentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBoxes();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0) {
                Student addStudent = new Student {
                    Name = nameBox.Text,
                    UMID = umidBox.Text,
                    Credits_Earned = Convert.ToInt32(creditsBox.Text),
                    Major_Id = (majorDropdown.SelectedItem as Major).Id
                };
                collegeEntities.Students.Add(addStudent);
                collegeEntities.SaveChanges();
                UpdateBoxes();
                studentListBox.DataSource = null;
                studentListBox.DataSource = (filteredList.Count == 0) ? collegeEntities.Students.ToList() : filteredList;
                studentListBox.SelectedIndex = studentListBox.Items.Count-1;
            } else
            {
                switch (EmptyBox())
                {
                    case 2: nameBox.Text = "Error! Name empty"; break;
                    case 3: umidBox.Text = "Error! UMID empty"; break;
                    case 4: creditsBox.Text = "Error! Credits empty"; break;
                }
            }
        }

        private void updateStudent_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0)
            {
                Student updateStudent = selectedStudent;
                if (updateStudent != null) {
                    updateStudent.Name = nameBox.Text;
                    updateStudent.UMID = umidBox.Text;
                    updateStudent.Credits_Earned = Convert.ToInt32(creditsBox.Text);
                    updateStudent.Major_Id = (majorDropdown.SelectedItem as Major).Id;
                    collegeEntities.SaveChanges();
                    UpdateBoxes();
                    int currIndex = studentListBox.SelectedIndex;
                    studentListBox.DataSource = null;
                    studentListBox.DataSource = (filteredList.Count == 0) ? collegeEntities.Students.ToList() : filteredList;
                    studentListBox.SelectedIndex = currIndex;
                }
            } else {
                switch (EmptyBox()) {
                    case 2: nameBox.Text = "Error! Name empty"; break;
                    case 3: umidBox.Text = "Error! UMID empty"; break;
                    case 4: creditsBox.Text = "Error! Credits empty"; break;
                }
            }
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            Student deleteStudent = selectedStudent;
            if (deleteStudent != null)
            {
                collegeEntities.deleteEnrollments(deleteStudent);
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
            bool emptyFilter = studentFormLookupBox.Text == "";
            if (!emptyFilter) {
                filteredList = collegeEntities.Students.ToList();
                if (!emptyFilter)
                    filteredList = filteredList.Where(c => c.Major.Name.ToUpper().Contains(studentFormLookupBox.Text.ToUpper())).ToList();
                studentListBox.DataSource = filteredList;
                if (filteredList.Count > 0)
                    studentListBox.SelectedItem = filteredList[0];
            } else {
                filteredList.Clear();
                studentListBox.DataSource = collegeEntities.Students.ToList();
                if (collegeEntities.Students.ToList().Count > 0)
                    studentListBox.SelectedItem = collegeEntities.Students.ToList()[0];
            }
            UpdateBoxes();
        }
    }
}
