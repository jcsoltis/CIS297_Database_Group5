namespace WindowsFormsApp1
{
    partial class CourseForm
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
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.creditsBox = new System.Windows.Forms.TextBox();
            this.courseFormLookupBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseListBox
            // 
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.Location = new System.Drawing.Point(12, 38);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(212, 134);
            this.courseListBox.TabIndex = 0;
            this.courseListBox.SelectedIndexChanged += new System.EventHandler(this.courseBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Credits";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 289);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(59, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addCourse_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(80, 289);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(59, 23);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateCourse_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(145, 289);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(59, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteCourse_Click);
            // 
            // departmentBox
            // 
            this.departmentBox.Location = new System.Drawing.Point(78, 197);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(146, 20);
            this.departmentBox.TabIndex = 10;
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(78, 218);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(146, 20);
            this.numberBox.TabIndex = 11;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(78, 241);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(146, 20);
            this.nameBox.TabIndex = 12;
            // 
            // creditsBox
            // 
            this.creditsBox.Location = new System.Drawing.Point(78, 263);
            this.creditsBox.Name = "creditsBox";
            this.creditsBox.Size = new System.Drawing.Size(146, 20);
            this.creditsBox.TabIndex = 13;
            // 
            // courseFormLookupBox
            // 
            this.courseFormLookupBox.Location = new System.Drawing.Point(125, 7);
            this.courseFormLookupBox.Margin = new System.Windows.Forms.Padding(2);
            this.courseFormLookupBox.Name = "courseFormLookupBox";
            this.courseFormLookupBox.Size = new System.Drawing.Size(77, 20);
            this.courseFormLookupBox.TabIndex = 28;
            this.courseFormLookupBox.TextChanged += new System.EventHandler(this.courseFormLookupBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Filter By Department:";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseFormLookupBox);
            this.Controls.Add(this.creditsBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseListBox);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox courseListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox creditsBox;
        private System.Windows.Forms.TextBox courseFormLookupBox;
        private System.Windows.Forms.Label label1;
    }
}