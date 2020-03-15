﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        CollegeEntities collegeEntities;
        CourseForm courseForm;
        EnrollmentForm enrollmentForm;
        InstructorForm instructorForm;
        MajorForm majorForm;
        SectionForm sectionForm;
        StudentForm studentForm;
        public Form1() {
            collegeEntities = new CollegeEntities();
            courseForm = new CourseForm();
            enrollmentForm = new EnrollmentForm();
            instructorForm = new InstructorForm();
            majorForm = new MajorForm();
            sectionForm = new SectionForm();
            studentForm = new StudentForm();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int instructorId = Convert.ToInt32(textBox1.Text);
            Instructor eric = new Instructor {
                Id = instructorId,
                Name = "Eric",
                Phone = "248-762-4206",
                Office = "CIS 237"
            };
            instructorId++;
            string connectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=ClassFeb20;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            label1.Text = eric.Id.ToString() + eric.Name + eric.Phone + eric.Office;

            collegeEntities.Instructors.Add(eric);
            foreach(Instructor instructor in collegeEntities.Instructors)
            {
                listBox1.Items.Add(instructor.Id);
            }
            collegeEntities.SaveChanges();
        }

        private void CourseForm_Click(object sender, EventArgs e)
        {
            courseForm.Show();
        }

        private void EnrollmentForm_Click(object sender, EventArgs e)
        {
            enrollmentForm.Show();
        }

        private void InstructorForm_Click(object sender, EventArgs e)
        {
            instructorForm.Show();
        }

        private void MajorForm_Click(object sender, EventArgs e)
        {
            majorForm.Show();
        }

        private void SectionForm_Click(object sender, EventArgs e)
        {
            sectionForm.Show();
        }

        private void StudentForm_Click(object sender, EventArgs e)
        {
            studentForm.Show();
        }
    }
}