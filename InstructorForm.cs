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
    public partial class InstructorForm : Form
    {
        CollegeEntities collegeEntities;
        Instructor selectedInstructor;
        public InstructorForm()
        {
            collegeEntities = new CollegeEntities();
            selectedInstructor = new Instructor();
            InitializeComponent();
            UpdateBoxes();
        }

        private void UpdateBoxes()
        {
            selectedInstructor = instructorListBox.SelectedItem as Instructor;
            if (selectedInstructor != null)
            {
                idBox.Text = selectedInstructor.Id.ToString();
                nameBox.Text = selectedInstructor.Name;
                phoneBox.Text = selectedInstructor.Phone;
                officeBox.Text = selectedInstructor.Office;
            }
            instructorListBox.Items.Clear();
            foreach (var instructor in collegeEntities.Instructors)
            {
                instructorListBox.Items.Add(instructor);
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
            else if (phoneBox.Text == "")
            {
                emptyBox = 3;
            }
            else if (officeBox.Text == "")
            {
                emptyBox = 4;
            }
            return emptyBox;
        }

        private void instructorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBoxes();
        }

        private void addInstructor_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0)
            {
                bool idEmpty = true;
                foreach (var instructor in collegeEntities.Instructors)
                {
                    if (instructor.Id == Convert.ToInt32(idBox.Text))
                    {
                        idEmpty = false;
                    }
                }
                if (idEmpty)
                {
                    Instructor addInstructor = new Instructor
                    {
                        Id = Convert.ToInt32(idBox.Text),
                        Name = nameBox.Text,
                        Phone = phoneBox.Text,
                        Office = officeBox.Text,
                    };
                    collegeEntities.Instructors.Add(addInstructor);
                    collegeEntities.SaveChanges();
                    UpdateBoxes();
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
                    case 3: phoneBox.Text = "Error! Phone empty"; break;
                    case 4: officeBox.Text = "Error! Office empty"; break;
                }
            }
        }

        private void updateInstructor_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0)
            {
                Instructor updateInstructor = collegeEntities.Instructors.Find(Convert.ToInt32(idBox.Text));
                if (updateInstructor != null)
                {
                    updateInstructor.Name = nameBox.Text;
                    updateInstructor.Phone = phoneBox.Text;
                    updateInstructor.Office = officeBox.Text;
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
                    case 3: phoneBox.Text = "Error! Phone empty"; break;
                    case 4: officeBox.Text = "Error! Office empty"; break;
                }
            }
        }

        private void deleteInstructor_Click(object sender, EventArgs e)
        {
            Instructor deleteInstructor = selectedInstructor;
            if (deleteInstructor != null)
            {
                collegeEntities.Instructors.Remove(deleteInstructor);
            }
            collegeEntities.SaveChanges();
            UpdateBoxes();
        }

        private void instructorFormLookupBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
