namespace WindowsFormsApp1
{
    partial class EnrollmentForm
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enrollmentListBox = new System.Windows.Forms.ListBox();
            this.enrollmentFormLookupBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.enrollmentFormLookupSemesterBox = new System.Windows.Forms.TextBox();
            this.gradeTextbox = new System.Windows.Forms.NumericUpDown();
            this.sectionDropdown = new System.Windows.Forms.ComboBox();
            this.studentDropdown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(145, 267);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(59, 23);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteEnrollment_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(80, 267);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(59, 23);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateEnrollment_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 267);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(59, 23);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addEnrollment_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Student";
            // 
            // enrollmentListBox
            // 
            this.enrollmentListBox.FormattingEnabled = true;
            this.enrollmentListBox.Location = new System.Drawing.Point(12, 38);
            this.enrollmentListBox.Name = "enrollmentListBox";
            this.enrollmentListBox.Size = new System.Drawing.Size(289, 134);
            this.enrollmentListBox.TabIndex = 14;
            this.enrollmentListBox.SelectedIndexChanged += new System.EventHandler(this.enrollmentBox_SelectedIndexChanged);
            // 
            // enrollmentFormLookupBox
            // 
            this.enrollmentFormLookupBox.Location = new System.Drawing.Point(95, 12);
            this.enrollmentFormLookupBox.Margin = new System.Windows.Forms.Padding(2);
            this.enrollmentFormLookupBox.Name = "enrollmentFormLookupBox";
            this.enrollmentFormLookupBox.Size = new System.Drawing.Size(76, 20);
            this.enrollmentFormLookupBox.TabIndex = 27;
            this.enrollmentFormLookupBox.TextChanged += new System.EventHandler(this.enrollmentFormLookupBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Filter By Student";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Semester";
            // 
            // enrollmentFormLookupSemesterBox
            // 
            this.enrollmentFormLookupSemesterBox.Location = new System.Drawing.Point(226, 12);
            this.enrollmentFormLookupSemesterBox.Margin = new System.Windows.Forms.Padding(2);
            this.enrollmentFormLookupSemesterBox.Name = "enrollmentFormLookupSemesterBox";
            this.enrollmentFormLookupSemesterBox.Size = new System.Drawing.Size(76, 20);
            this.enrollmentFormLookupSemesterBox.TabIndex = 29;
            this.enrollmentFormLookupSemesterBox.TextChanged += new System.EventHandler(this.enrollmentFormLookupBox_TextChanged);
            // 
            // gradeTextbox
            // 
            this.gradeTextbox.Location = new System.Drawing.Point(78, 240);
            this.gradeTextbox.Name = "gradeTextbox";
            this.gradeTextbox.Size = new System.Drawing.Size(224, 20);
            this.gradeTextbox.TabIndex = 31;
            // 
            // sectionDropdown
            // 
            this.sectionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionDropdown.FormattingEnabled = true;
            this.sectionDropdown.Location = new System.Drawing.Point(78, 215);
            this.sectionDropdown.Name = "sectionDropdown";
            this.sectionDropdown.Size = new System.Drawing.Size(223, 21);
            this.sectionDropdown.TabIndex = 47;
            // 
            // studentDropdown
            // 
            this.studentDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentDropdown.FormattingEnabled = true;
            this.studentDropdown.Location = new System.Drawing.Point(78, 189);
            this.studentDropdown.Name = "studentDropdown";
            this.studentDropdown.Size = new System.Drawing.Size(223, 21);
            this.studentDropdown.TabIndex = 48;
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 296);
            this.Controls.Add(this.studentDropdown);
            this.Controls.Add(this.sectionDropdown);
            this.Controls.Add(this.gradeTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enrollmentFormLookupSemesterBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enrollmentFormLookupBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enrollmentListBox);
            this.Name = "EnrollmentForm";
            this.Text = "EnrollmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.gradeTextbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox enrollmentListBox;
        private System.Windows.Forms.TextBox enrollmentFormLookupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox enrollmentFormLookupSemesterBox;
        private System.Windows.Forms.NumericUpDown gradeTextbox;
        private System.Windows.Forms.ComboBox sectionDropdown;
        private System.Windows.Forms.ComboBox studentDropdown;
    }
}