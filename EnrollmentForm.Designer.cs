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
            this.gradeBox = new System.Windows.Forms.TextBox();
            this.sectionIdBox = new System.Windows.Forms.TextBox();
            this.studentIdBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enrollmentListBox = new System.Windows.Forms.ListBox();
            this.enrollmentFormLookupBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gradeBox
            // 
            this.gradeBox.Location = new System.Drawing.Point(104, 297);
            this.gradeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(193, 22);
            this.gradeBox.TabIndex = 26;
            // 
            // sectionIdBox
            // 
            this.sectionIdBox.Location = new System.Drawing.Point(104, 268);
            this.sectionIdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sectionIdBox.Name = "sectionIdBox";
            this.sectionIdBox.Size = new System.Drawing.Size(193, 22);
            this.sectionIdBox.TabIndex = 25;
            // 
            // studentIdBox
            // 
            this.studentIdBox.Location = new System.Drawing.Point(104, 242);
            this.studentIdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentIdBox.Name = "studentIdBox";
            this.studentIdBox.Size = new System.Drawing.Size(193, 22);
            this.studentIdBox.TabIndex = 24;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(104, 215);
            this.idBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(193, 22);
            this.idBox.TabIndex = 23;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(193, 329);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(79, 28);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteEnrollment_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(107, 329);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(79, 28);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateEnrollment_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(20, 329);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(79, 28);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addEnrollment_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Section Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Student Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id";
            // 
            // enrollmentListBox
            // 
            this.enrollmentListBox.FormattingEnabled = true;
            this.enrollmentListBox.ItemHeight = 16;
            this.enrollmentListBox.Location = new System.Drawing.Point(16, 47);
            this.enrollmentListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enrollmentListBox.Name = "enrollmentListBox";
            this.enrollmentListBox.Size = new System.Drawing.Size(281, 164);
            this.enrollmentListBox.TabIndex = 14;
            this.enrollmentListBox.SelectedIndexChanged += new System.EventHandler(this.enrollmentBox_SelectedIndexChanged);
            // 
            // enrollmentFormLookupBox
            // 
            this.enrollmentFormLookupBox.Location = new System.Drawing.Point(16, 12);
            this.enrollmentFormLookupBox.Name = "enrollmentFormLookupBox";
            this.enrollmentFormLookupBox.Size = new System.Drawing.Size(100, 22);
            this.enrollmentFormLookupBox.TabIndex = 27;
            this.enrollmentFormLookupBox.TextChanged += new System.EventHandler(this.enrollmentFormLookupBox_TextChanged);
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 364);
            this.Controls.Add(this.enrollmentFormLookupBox);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.sectionIdBox);
            this.Controls.Add(this.studentIdBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enrollmentListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EnrollmentForm";
            this.Text = "EnrollmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox gradeBox;
        private System.Windows.Forms.TextBox sectionIdBox;
        private System.Windows.Forms.TextBox studentIdBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox enrollmentListBox;
        private System.Windows.Forms.TextBox enrollmentFormLookupBox;
    }
}