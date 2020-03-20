using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
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
            try
            {
                collegeEntities.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            foreach (Instructor instructor in collegeEntities.Instructors)
            {
                listBox1.Items.Add(instructor.Id);
            }
           
        }

        private void CourseForm_Click(object sender, EventArgs e)
        {
            courseForm = new CourseForm();
            courseForm.Show(); //these forms will only show once and then the program will crash for some reason
        }

        private void EnrollmentForm_Click(object sender, EventArgs e)
        {
            enrollmentForm = new EnrollmentForm();
            enrollmentForm.Show();
        }

        private void InstructorForm_Click(object sender, EventArgs e)
        {
            instructorForm = new InstructorForm();
            instructorForm.Show();
        }

        private void MajorForm_Click(object sender, EventArgs e)
        {
            majorForm = new MajorForm();
            majorForm.Show();
        }

        private void SectionForm_Click(object sender, EventArgs e)
        {
            sectionForm = new SectionForm();
            sectionForm.Show();
        }

        private void StudentForm_Click(object sender, EventArgs e)
        {
            studentForm = new StudentForm();
            studentForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        //idea of updating search based off of filter in text box came from in class example from charnesky
        public void updateSearch(string text)
        {
            label2.Text = "";
            foreach (var course in collegeEntities.Courses.Where(c => c.Sections.Count > 0).Where(c => c.Department == courseLookupComboBox.Text))  //very useful clause for searching stuff with filters foreach (var course in collegeEntities.Courses.Where(c => c.Enrollment.Count < 30
            {
                if(text == "")//used to make sure no classes are showing up when no text is in the search bar 
                {
                    break;
                }
                if (text != "" &&
                    !course.Number.StartsWith(text))
                {
                    continue;
                    
                }
                


                label2.Text = $"{course} {Environment.NewLine}";
                foreach (var section in course.Sections)
                {
                    label2.Text += $"         {section.Instructor.Name} {section.Days} {section.Time}{Environment.NewLine}";
                }
            }
        }

        private void courseLookupTextBox_TextChanged(object sender, EventArgs e)
        {
            updateSearch(courseLookupTextBox.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseLookupTextBox.Text = "";
            label2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.collegeDataSet.Course);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.courseTableAdapter.FillBy(this.collegeDataSet.Course);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
