﻿namespace WindowsFormsApp1
{
    partial class SectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.daysBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sectionListBox = new System.Windows.Forms.ListBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sectionFormLookupBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sectionFormLookupFacultyBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.courseDropdown = new System.Windows.Forms.ComboBox();
            this.semesterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.instructorDropdown = new System.Windows.Forms.ComboBox();
            this.gradesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daysBox
            // 
            this.daysBox.Location = new System.Drawing.Point(117, 371);
            this.daysBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.daysBox.Name = "daysBox";
            this.daysBox.Size = new System.Drawing.Size(463, 26);
            this.daysBox.TabIndex = 38;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(218, 482);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 35);
            this.deleteButton.TabIndex = 34;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteSection_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(120, 482);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 35);
            this.updateButton.TabIndex = 33;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateSection_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(22, 482);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 35);
            this.addButton.TabIndex = 32;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addSection_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 371);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Instructor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Course";
            // 
            // sectionListBox
            // 
            this.sectionListBox.FormattingEnabled = true;
            this.sectionListBox.ItemHeight = 20;
            this.sectionListBox.Location = new System.Drawing.Point(18, 58);
            this.sectionListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sectionListBox.Name = "sectionListBox";
            this.sectionListBox.Size = new System.Drawing.Size(562, 204);
            this.sectionListBox.TabIndex = 27;
            this.sectionListBox.SelectedIndexChanged += new System.EventHandler(this.sectionBox_SelectedIndexChanged);
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(117, 406);
            this.timeBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(463, 26);
            this.timeBox.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 406);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Time";
            // 
            // sectionFormLookupBox
            // 
            this.sectionFormLookupBox.Location = new System.Drawing.Point(152, 15);
            this.sectionFormLookupBox.Name = "sectionFormLookupBox";
            this.sectionFormLookupBox.Size = new System.Drawing.Size(112, 26);
            this.sectionFormLookupBox.TabIndex = 41;
            this.sectionFormLookupBox.TextChanged += new System.EventHandler(this.sectionFormLookupBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "By Faculty";
            // 
            // sectionFormLookupFacultyBox
            // 
            this.sectionFormLookupFacultyBox.Location = new System.Drawing.Point(352, 15);
            this.sectionFormLookupFacultyBox.Name = "sectionFormLookupFacultyBox";
            this.sectionFormLookupFacultyBox.Size = new System.Drawing.Size(112, 26);
            this.sectionFormLookupFacultyBox.TabIndex = 43;
            this.sectionFormLookupFacultyBox.TextChanged += new System.EventHandler(this.sectionFormLookupBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Filter By Semester";
            // 
            // courseDropdown
            // 
            this.courseDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseDropdown.FormattingEnabled = true;
            this.courseDropdown.Location = new System.Drawing.Point(117, 295);
            this.courseDropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courseDropdown.Name = "courseDropdown";
            this.courseDropdown.Size = new System.Drawing.Size(463, 28);
            this.courseDropdown.TabIndex = 46;
            // 
            // semesterTextBox
            // 
            this.semesterTextBox.Location = new System.Drawing.Point(117, 445);
            this.semesterTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.semesterTextBox.Name = "semesterTextBox";
            this.semesterTextBox.Size = new System.Drawing.Size(463, 26);
            this.semesterTextBox.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 445);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Semester";
            // 
            // instructorDropdown
            // 
            this.instructorDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instructorDropdown.FormattingEnabled = true;
            this.instructorDropdown.Location = new System.Drawing.Point(117, 334);
            this.instructorDropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.instructorDropdown.Name = "instructorDropdown";
            this.instructorDropdown.Size = new System.Drawing.Size(463, 28);
            this.instructorDropdown.TabIndex = 49;
            // 
            // gradesButton
            // 
            this.gradesButton.Location = new System.Drawing.Point(313, 482);
            this.gradesButton.Name = "gradesButton";
            this.gradesButton.Size = new System.Drawing.Size(267, 35);
            this.gradesButton.TabIndex = 50;
            this.gradesButton.Text = "Display grade distribution";
            this.gradesButton.UseVisualStyleBackColor = true;
            this.gradesButton.Click += new System.EventHandler(this.gradesButton_Click);
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 525);
            this.Controls.Add(this.gradesButton);
            this.Controls.Add(this.instructorDropdown);
            this.Controls.Add(this.semesterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseDropdown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sectionFormLookupFacultyBox);
            this.Controls.Add(this.sectionFormLookupBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.daysBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sectionListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SectionForm";
            this.Text = "SectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox daysBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox sectionListBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sectionFormLookupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sectionFormLookupFacultyBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox courseDropdown;
        private System.Windows.Forms.TextBox semesterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox instructorDropdown;
        private System.Windows.Forms.Button gradesButton;
    }
}