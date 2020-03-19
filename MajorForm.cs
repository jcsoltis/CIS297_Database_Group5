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
    public partial class MajorForm : Form
    {
        CollegeEntities collegeEntities;
        Major selectedMajor;
        public MajorForm()
        {
            collegeEntities = new CollegeEntities();
            selectedMajor = new Major();
            InitializeComponent();
            UpdateBoxes();
        }

        private void UpdateBoxes()
        {
            selectedMajor = majorListBox.SelectedItem as Major;
            if (selectedMajor != null)
            {
                idBox.Text = selectedMajor.Id.ToString();
                nameBox.Text = selectedMajor.Name;
            }
            majorListBox.Items.Clear();
            foreach (var major in collegeEntities.Majors)
            {
                majorListBox.Items.Add(major);
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
            return emptyBox;
        }

        private void majorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBoxes();
        }

        private void addMajor_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0)
            {
                bool idEmpty = true;
                foreach (var major in collegeEntities.Majors)
                {
                    if (major.Id == Convert.ToInt32(idBox.Text))
                    {
                        idEmpty = false;
                    }
                }
                if (idEmpty)
                {
                    Major addMajor = new Major
                    {
                        Id = Convert.ToInt32(idBox.Text),
                        Name = nameBox.Text,
                    };
                    collegeEntities.Majors.Add(addMajor);
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
                }
            }
        }

        private void updateMajor_Click(object sender, EventArgs e)
        {
            if (EmptyBox() == 0)
            {
                Major updateMajor = collegeEntities.Majors.Find(Convert.ToInt32(idBox.Text));
                if (updateMajor != null)
                {
                    updateMajor.Name = nameBox.Text;
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
                }
            }
        }

        private void deleteMajor_Click(object sender, EventArgs e)
        {
            Major deleteMajor = selectedMajor;
            if (deleteMajor != null)
            {
                collegeEntities.Majors.Remove(deleteMajor);
            }
            collegeEntities.SaveChanges();
            UpdateBoxes();
        }

        private void majorFormLookupBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
