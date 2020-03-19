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
            this.idBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.instructorListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // officeBox
            // 
            this.officeBox.Location = new System.Drawing.Point(104, 297);
            this.officeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.officeBox.Name = "officeBox";
            this.officeBox.Size = new System.Drawing.Size(193, 22);
            this.officeBox.TabIndex = 38;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(104, 268);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(193, 22);
            this.phoneBox.TabIndex = 37;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(104, 242);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(193, 22);
            this.nameBox.TabIndex = 36;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(104, 215);
            this.idBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(193, 22);
            this.idBox.TabIndex = 35;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(193, 329);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(79, 28);
            this.deleteButton.TabIndex = 34;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteInstructor_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(107, 329);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(79, 28);
            this.updateButton.TabIndex = 33;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateInstructor_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(20, 329);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(79, 28);
            this.addButton.TabIndex = 32;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addInstructor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Office";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Phone #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Id";
            // 
            // instructorListBox
            // 
            this.instructorListBox.FormattingEnabled = true;
            this.instructorListBox.ItemHeight = 16;
            this.instructorListBox.Location = new System.Drawing.Point(16, 47);
            this.instructorListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.instructorListBox.Name = "instructorListBox";
            this.instructorListBox.Size = new System.Drawing.Size(281, 164);
            this.instructorListBox.TabIndex = 27;
            this.instructorListBox.SelectedIndexChanged += new System.EventHandler(this.instructorBox_SelectedIndexChanged);
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 364);
            this.Controls.Add(this.officeBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instructorListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InstructorForm";
            this.Text = "InstructorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox officeBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox instructorListBox;
    }
}