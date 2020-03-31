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
    public partial class GradeDistributionForm : Form
    {
        CollegeEntities collegeEntities;
        Section selectedSection = new Section();
        public GradeDistributionForm(Section s)
        {
            collegeEntities = new CollegeEntities();
            selectedSection = s;
            InitializeComponent();

            labelForName.Text = "Grade distributions for " + selectedSection.ToString();  //selectedSection.Course.Name + " with " + selectedSection.Instructor.Name;
            displayGradesPercentages();

        }

        private void displayGradesPercentages()
        {
            List<string> grade_letters = new List<string>() { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "E" };
            List<double> grade_percentages = getGradePercentages();

            if (grade_percentages == null)
                gradesLabel.Text = "There are no enrollments in this section";
            else
            {
                for (int i = 0; i < 13; i++)
                {
                    if (grade_percentages[i] != 0)
                    {
                        if (grade_letters[i].Length == 1)
                            gradesLabel.Text += grade_letters[i] + "            " + Convert.ToInt32(grade_percentages[i]) + "%" + Environment.NewLine;
                        else
                            gradesLabel.Text += grade_letters[i] + "          " + Convert.ToInt32(grade_percentages[i]) + "%" + Environment.NewLine;
                    }
                }
            }
        }
        private List<double> getGradePercentages()
        {
            List<int> grades = new List<int>();
            List<double> grade_percentages = new List<double>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            int amount_of_students = 0;
            foreach (var enrollment in collegeEntities.Enrollments.Where(c => c.Section_Id == selectedSection.Id))
            {
                grades.Add(Convert.ToInt32(enrollment.Grade));
                amount_of_students++;
            }
            if (amount_of_students == 0)
                return null;

            for (int i = 0; i < grades.Count(); i++)
            {
                if (grades[i] > 96)
                {
                    grade_percentages[0]++;
                }
                else if (grades[i] > 92)
                {
                    grade_percentages[1]++;
                }
                else if (grades[i] > 89)
                {
                    grade_percentages[2]++;
                }
                else if (grades[i] > 86)
                {
                    grade_percentages[3]++;
                }
                else if (grades[i] > 82)
                {
                    grade_percentages[4]++;
                }
                else if (grades[i] > 79)
                {
                    grade_percentages[5]++;
                }
                else if (grades[i] > 76)
                {
                    grade_percentages[6]++;
                }
                else if (grades[i] > 72)
                {
                    grade_percentages[7]++;
                }
                else if (grades[i] > 69)
                {
                    grade_percentages[8]++;

                }
                else if (grades[i] > 66)
                {
                    grade_percentages[9]++;
                }
                else if (grades[i] > 62)
                {
                    grade_percentages[10]++;
                }
                else if (grades[i] > 59)
                {
                    grade_percentages[11]++;
                }
                else
                {
                    grade_percentages[12]++;
                }
            }

            for (int i = 0; i < grade_percentages.Count(); i++)
            {
                if (grade_percentages[i] != 0)
                    grade_percentages[i] = (grade_percentages[i]/amount_of_students) * 100;
            }

            return grade_percentages;
        }

    }
}


