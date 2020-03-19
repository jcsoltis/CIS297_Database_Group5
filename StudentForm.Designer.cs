namespace WindowsFormsApp1
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
            this.majorIdBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.creditsBox = new System.Windows.Forms.TextBox();
            this.umidBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.studentFormLookupBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // majorIdBox
            // 
            this.majorIdBox.Location = new System.Drawing.Point(104, 325);
            this.majorIdBox.Margin = new System.Windows.Forms.Padding(4);
            this.majorIdBox.Name = "majorIdBox";
            this.majorIdBox.Size = new System.Drawing.Size(193, 22);
            this.majorIdBox.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 325);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Major Id";
            // 
            // creditsBox
            // 
            this.creditsBox.Location = new System.Drawing.Point(104, 297);
            this.creditsBox.Margin = new System.Windows.Forms.Padding(4);
            this.creditsBox.Name = "creditsBox";
            this.creditsBox.Size = new System.Drawing.Size(193, 22);
            this.creditsBox.TabIndex = 52;
            // 
            // umidBox
            // 
            this.umidBox.Location = new System.Drawing.Point(104, 268);
            this.umidBox.Margin = new System.Windows.Forms.Padding(4);
            this.umidBox.Name = "umidBox";
            this.umidBox.Size = new System.Drawing.Size(193, 22);
            this.umidBox.TabIndex = 51;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(104, 242);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(193, 22);
            this.nameBox.TabIndex = 50;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(104, 215);
            this.idBox.Margin = new System.Windows.Forms.Padding(4);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(193, 22);
            this.idBox.TabIndex = 49;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(193, 357);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(79, 28);
            this.deleteButton.TabIndex = 48;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(107, 357);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(79, 28);
            this.updateButton.TabIndex = 47;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateStudent_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(20, 357);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(79, 28);
            this.addButton.TabIndex = 46;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Credits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "UMID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Id";
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 16;
            this.studentListBox.Location = new System.Drawing.Point(16, 47);
            this.studentListBox.Margin = new System.Windows.Forms.Padding(4);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(281, 164);
            this.studentListBox.TabIndex = 41;
            // 
            // studentFormLookupBox
            // 
            this.studentFormLookupBox.Location = new System.Drawing.Point(16, 12);
            this.studentFormLookupBox.Name = "studentFormLookupBox";
            this.studentFormLookupBox.Size = new System.Drawing.Size(100, 22);
            this.studentFormLookupBox.TabIndex = 55;
            this.studentFormLookupBox.TextChanged += new System.EventHandler(this.studentFormLookupBox_TextChanged);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 391);
            this.Controls.Add(this.studentFormLookupBox);
            this.Controls.Add(this.majorIdBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.creditsBox);
            this.Controls.Add(this.umidBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox majorIdBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox creditsBox;
        private System.Windows.Forms.TextBox umidBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.TextBox studentFormLookupBox;
    }
}