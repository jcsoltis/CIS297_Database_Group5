namespace WindowsFormsApp1
{
    partial class InstructorForm
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
            this.officeBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.instructorListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // officeBox
            // 
            this.officeBox.Location = new System.Drawing.Point(78, 241);
            this.officeBox.Name = "officeBox";
            this.officeBox.Size = new System.Drawing.Size(212, 20);
            this.officeBox.TabIndex = 38;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(78, 218);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(212, 20);
            this.phoneBox.TabIndex = 37;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(78, 197);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(212, 20);
            this.nameBox.TabIndex = 36;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(145, 267);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(59, 23);
            this.deleteButton.TabIndex = 34;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteInstructor_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(80, 267);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(59, 23);
            this.updateButton.TabIndex = 33;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateInstructor_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 267);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(59, 23);
            this.addButton.TabIndex = 32;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addInstructor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Office";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Phone #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name";
            // 
            // instructorListBox
            // 
            this.instructorListBox.FormattingEnabled = true;
            this.instructorListBox.Location = new System.Drawing.Point(12, 38);
            this.instructorListBox.Name = "instructorListBox";
            this.instructorListBox.Size = new System.Drawing.Size(278, 134);
            this.instructorListBox.TabIndex = 27;
            this.instructorListBox.SelectedIndexChanged += new System.EventHandler(this.instructorBox_SelectedIndexChanged);
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 296);
            this.Controls.Add(this.officeBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.instructorListBox);
            this.Name = "InstructorForm";
            this.Text = "InstructorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox officeBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox instructorListBox;
    }
}