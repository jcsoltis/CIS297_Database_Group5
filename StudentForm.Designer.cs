﻿namespace WindowsFormsApp1
{
    partial class StudentForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.creditsBox = new System.Windows.Forms.TextBox();
            this.umidBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.studentFormLookupBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.majorDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Major Id";
            // 
            // creditsBox
            // 
            this.creditsBox.Location = new System.Drawing.Point(78, 241);
            this.creditsBox.Name = "creditsBox";
            this.creditsBox.Size = new System.Drawing.Size(227, 20);
            this.creditsBox.TabIndex = 52;
            // 
            // umidBox
            // 
            this.umidBox.Location = new System.Drawing.Point(78, 218);
            this.umidBox.Name = "umidBox";
            this.umidBox.Size = new System.Drawing.Size(227, 20);
            this.umidBox.TabIndex = 51;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(78, 197);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(227, 20);
            this.nameBox.TabIndex = 50;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(145, 290);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(59, 23);
            this.deleteButton.TabIndex = 48;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(80, 290);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(59, 23);
            this.updateButton.TabIndex = 47;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateStudent_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 290);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(59, 23);
            this.addButton.TabIndex = 46;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Credits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "UMID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Name";
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(12, 38);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(293, 134);
            this.studentListBox.TabIndex = 41;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentBox_SelectedIndexChanged);
            // 
            // studentFormLookupBox
            // 
            this.studentFormLookupBox.Location = new System.Drawing.Point(89, 10);
            this.studentFormLookupBox.Margin = new System.Windows.Forms.Padding(2);
            this.studentFormLookupBox.Name = "studentFormLookupBox";
            this.studentFormLookupBox.Size = new System.Drawing.Size(76, 20);
            this.studentFormLookupBox.TabIndex = 55;
            this.studentFormLookupBox.TextChanged += new System.EventHandler(this.studentFormLookupBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Filter By Major";
            // 
            // majorDropdown
            // 
            this.majorDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.majorDropdown.FormattingEnabled = true;
            this.majorDropdown.Location = new System.Drawing.Point(78, 264);
            this.majorDropdown.Name = "majorDropdown";
            this.majorDropdown.Size = new System.Drawing.Size(227, 21);
            this.majorDropdown.TabIndex = 57;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 318);
            this.Controls.Add(this.majorDropdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.studentFormLookupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.creditsBox);
            this.Controls.Add(this.umidBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentListBox);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox creditsBox;
        private System.Windows.Forms.TextBox umidBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.TextBox studentFormLookupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox majorDropdown;
    }
}