using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class EnrollmentForm : Form {
        CollegeEntities collegeEntities;
        Enrollment selectedEnrollment;
        List<Enrollment> filteredList;
        public EnrollmentForm() {
            collegeEntities = new CollegeEntities();
            selectedEnrollment = new Enrollment();
            InitializeComponent();
            filteredList = new List<Enrollment>();
            enrollmentListBox.DataSource = collegeEntities.Enrollments.ToList();
            studentDropdown.DataSource = collegeEntities.Students.ToList();
            sectionDropdown.DataSource = collegeEntities.Sections.ToList();
            if (collegeEntities.Enrollments.ToList().Count > 0)
                enrollmentListBox.SelectedItem = collegeEntities.Enrollments.ToList()[0];
            UpdateBoxes();
        }

        private void UpdateBoxes() {
            selectedEnrollment = enrollmentListBox.SelectedItem as Enrollment;
            if (selectedEnrollment != null) {
                if (studentDropdown.Items.Count > 0)
                    studentDropdown.SelectedIndex = selectedEnrollment.Student_Id - 1;
                if (sectionDropdown.Items.Count > 0)
                    sectionDropdown.SelectedIndex = selectedEnrollment.Section_Id - 1;
                gradeTextbox.Value = (int)selectedEnrollment.Grade;
            }
        }

        private void enrollmentBox_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateBoxes();
        }

        private void addEnrollment_Click(object sender, EventArgs e) {
            Enrollment addEnrollment = new Enrollment {
                Student_Id = (studentDropdown.SelectedItem as Student).Id,
                Section_Id = (sectionDropdown.SelectedItem as Section).Id,
                Grade = Convert.ToDouble(gradeTextbox.Value)
            };
            collegeEntities.Enrollments.Add(addEnrollment);
            collegeEntities.SaveChanges();
            UpdateBoxes();
            enrollmentListBox.DataSource = null;
            enrollmentListBox.DataSource = (filteredList.Count == 0) ? collegeEntities.Enrollments.ToList() : filteredList;
            enrollmentListBox.SelectedIndex = enrollmentListBox.Items.Count - 1;
        }

        private void updateEnrollment_Click(object sender, EventArgs e) {
            Enrollment updateEnrollment = selectedEnrollment;
            if (updateEnrollment != null) {
                updateEnrollment.Student_Id = (studentDropdown.SelectedItem as Student).Id;
                updateEnrollment.Section_Id = (sectionDropdown.SelectedItem as Section).Id;
                updateEnrollment.Grade = (int)gradeTextbox.Value;
                collegeEntities.SaveChanges();
                UpdateBoxes();
                int currIndex = enrollmentListBox.SelectedIndex;
                enrollmentListBox.DataSource = null;
                enrollmentListBox.DataSource = (filteredList.Count == 0) ? collegeEntities.Enrollments.ToList() : filteredList;
                enrollmentListBox.SelectedIndex = currIndex;
            }

        }

        private void deleteEnrollment_Click(object sender, EventArgs e) {
            Enrollment deleteEnrollment = selectedEnrollment;
            if (deleteEnrollment != null) {
                collegeEntities.Enrollments.Remove(deleteEnrollment);
            }
            collegeEntities.SaveChanges();
            UpdateBoxes();
        }

        private void enrollmentFormLookupBox_TextChanged(object sender, EventArgs e) {
            bool emptySemester = enrollmentFormLookupSemesterBox.Text == "";
            bool emptyStudent = enrollmentFormLookupBox.Text == "";
            if (!emptySemester || !emptyStudent) {
                filteredList = collegeEntities.Enrollments.ToList();
                if (!emptySemester)
                    filteredList = filteredList.Where(c => c.Section.Semester.ToUpper().Contains(enrollmentFormLookupSemesterBox.Text.ToUpper())).ToList();
                if (!emptyStudent)
                    filteredList = filteredList.Where(c => c.Student.Name.ToUpper().Contains(enrollmentFormLookupBox.Text.ToUpper())).ToList();
                enrollmentListBox.DataSource = filteredList;
                if (filteredList.Count > 0)
                    enrollmentListBox.SelectedItem = filteredList[0];
            } else {
                filteredList.Clear();
                enrollmentListBox.DataSource = collegeEntities.Enrollments.ToList();
                if (collegeEntities.Enrollments.ToList().Count > 0)
                    enrollmentListBox.SelectedItem = collegeEntities.Enrollments.ToList()[0];
            }
            UpdateBoxes();
        }
    }
}
