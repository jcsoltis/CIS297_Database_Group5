namespace WindowsFormsApp1
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
            this.instructorIdBox = new System.Windows.Forms.TextBox();
            this.courseIdBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sectionListBox = new System.Windows.Forms.ListBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daysBox
            // 
            this.daysBox.Location = new System.Drawing.Point(78, 241);
            this.daysBox.Name = "daysBox";
            this.daysBox.Size = new System.Drawing.Size(146, 20);
            this.daysBox.TabIndex = 38;
            // 
            // instructorIdBox
            // 
            this.instructorIdBox.Location = new System.Drawing.Point(78, 218);
            this.instructorIdBox.Name = "instructorIdBox";
            this.instructorIdBox.Size = new System.Drawing.Size(146, 20);
            this.instructorIdBox.TabIndex = 37;
            // 
            // courseIdBox
            // 
            this.courseIdBox.Location = new System.Drawing.Point(78, 197);
            this.courseIdBox.Name = "courseIdBox";
            this.courseIdBox.Size = new System.Drawing.Size(146, 20);
            this.courseIdBox.TabIndex = 36;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(78, 175);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(146, 20);
            this.idBox.TabIndex = 35;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(145, 290);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(59, 23);
            this.deleteButton.TabIndex = 34;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteSection_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(80, 290);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(59, 23);
            this.updateButton.TabIndex = 33;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateSection_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 290);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(59, 23);
            this.addButton.TabIndex = 32;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addSection_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Instructor Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Course Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Id";
            // 
            // sectionListBox
            // 
            this.sectionListBox.FormattingEnabled = true;
            this.sectionListBox.Location = new System.Drawing.Point(12, 12);
            this.sectionListBox.Name = "sectionListBox";
            this.sectionListBox.Size = new System.Drawing.Size(212, 160);
            this.sectionListBox.TabIndex = 27;
            this.sectionListBox.SelectedIndexChanged += new System.EventHandler(this.sectionBox_SelectedIndexChanged);
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(78, 264);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(146, 20);
            this.timeBox.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Time";
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 322);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.daysBox);
            this.Controls.Add(this.instructorIdBox);
            this.Controls.Add(this.courseIdBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sectionListBox);
            this.Name = "SectionForm";
            this.Text = "SectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox daysBox;
        private System.Windows.Forms.TextBox instructorIdBox;
        private System.Windows.Forms.TextBox courseIdBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox sectionListBox;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Label label5;
    }
}