﻿using System;
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
    public partial class CourseForm : Form
    {
        CollegeEntities collegeEntities;
        Course selectedCourse;
        public CourseForm()
        {
            collegeEntities = new CollegeEntities();
            selectedCourse = new Course();
            InitializeComponent();
            UpdateBoxes();
        }

        private void UpdateBoxes()
        {
            selectedCourse = courseListBox.SelectedItem as Course;
            if (selectedCourse != null)
            {
                //idBox.Text = selectedCourse.Id.ToString();
                departmentBox.Text = selectedCourse.Department;
                nameBox.Text = selectedCourse.Name;
                numberBox.Text = selectedCourse.Number;
                creditsBox.Text = selectedCourse.Credits.ToString();
            }
            courseListBox.Items.Clear();
            foreach (var course in collegeEntities.Courses)
            {
                courseListBox.Items.Add(course);
            }

            //courseListBox.SelectedItem = (object)selectedCourse;
        }
        public void updateSearch(string text)
        {
            courseListBox.Items.Clear();
            foreach (var course in collegeEntities.Courses.Where(c => c.Sections.Count > 0))  //very useful clause for searching stuff with filters foreach (var course in collegeEntities.Courses.Where(c => c.Enrollment.Count < 30
            {
                if (text == "")//used to make sure no classes are showing up when no text is in the search bar 
                {
                    break;
                }
                if (text != "" &&
                    !course.Department.StartsWith(text)) //start from here when you get back to filtering 
                {
                    continue;

                }



                courseListBox.Items.Add(course);
                foreach (var section in course.Sections)
                {
                  courseListBox.Items.Add($"{section.Instructor.Name} {section.Days} {section.Time}{Environment.NewLine}");
                }
            }
        }

        private int EmptyBox()
        {
            int emptyBox = 0;
            if (departmentBox.Text == "")
            {
                emptyBox = 2;
            }
            else if (numberBox.Text == "")
            {
                emptyBox = 3;
            }
            else if (nameBox.Text == "")
            {
                emptyBox = 4;
            }
            else if (creditsBox.Text == "")
            {
                emptyBox = 5;
            }
            return emptyBox;
        }

        private void courseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBoxes();
        }
        /*
         * private void facultyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instructor selectedInstructor = facultyListBox.SelectedItem as Instructor;
            nameTextBox.Text = selectedInstructor.Name;
            phoneTextBox.Text = selectedInstructor.Phone;
            officeTextBox.Text = selectedInstructor.Office;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instructor selectedInstructor = facultyListBox.SelectedItem as Instructor;
            selectedInstructor.Name = nameTextBox.Text;
            selectedInstructor.Phone = phoneTextBox.Text;
            selectedInstructor.Office = officeTextBox.Text;
            collegeEntities.SaveChanges();
        }
        */
        private void addCourse_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0)
            {
                /*bool idEmpty = true;
                foreach (var course in collegeEntities.Courses)
                {
                    if (course.Id == Convert.ToInt32(idBox.Text))
                    {
                        idEmpty = false;
                    }
                }
                if (idEmpty)
                {*/
                    Course addCourse = new Course
                    {
                        //Id = Convert.ToInt32(idBox.Text),
                        Department = departmentBox.Text,
                        Name = nameBox.Text,
                        Number = numberBox.Text,
                        Credits = Convert.ToInt32(creditsBox.Text)
                    };
                    collegeEntities.Courses.Add(addCourse);
                    collegeEntities.SaveChanges();
                    UpdateBoxes();
                //}
                //else
                //{
                //    idBox.Text = "Error! ID already exists";
                //}
            }
            else
            {
                switch (EmptyBox())
                {
                    //case 1: idBox.Text = "Error! ID empty"; break;
                    case 2: departmentBox.Text = "Error! Department empty"; break;
                    case 3: numberBox.Text = "Error! Number empty"; break;
                    case 4: nameBox.Text = "Error! Name empty"; break;
                    case 5: creditsBox.Text = "Error! Credits empty"; break;
                }
            }
        }

        private void updateCourse_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0)
            {
                Course updateCourse = selectedCourse;//collegeEntities.Courses.Find(Convert.ToInt32(idBox.Text));
                if (updateCourse != null)
                {
                    updateCourse.Department = departmentBox.Text;
                    updateCourse.Name = nameBox.Text;
                    updateCourse.Number = numberBox.Text;
                    updateCourse.Credits = Convert.ToInt32(creditsBox.Text);
                }
                else
                {
                    //idBox.Text = "ID does not exist to update";
                }
                
                collegeEntities.SaveChanges();
                UpdateBoxes();
            }
            else
            {
                switch (EmptyBox())
                {
                    //case 1: idBox.Text = "Error! ID empty"; break;
                    case 2: departmentBox.Text = "Error! Department empty"; break;
                    case 3: numberBox.Text = "Error! Number empty"; break;
                    case 4: nameBox.Text = "Error! Name empty"; break;
                    case 5: creditsBox.Text = "Error! Credits empty"; break;
                }
            }
        }

        private void deleteCourse_Click(object sender, EventArgs e)
        {
            Course deleteCourse = selectedCourse;
            if (deleteCourse != null)
            {
                collegeEntities.Courses.Remove(deleteCourse);
            }
            collegeEntities.SaveChanges();
            UpdateBoxes();
        }

        private void courseFormLookupBox_TextChanged(object sender, EventArgs e)
        {
            updateSearch(courseFormLookupBox.Text);
        }
    }
}
