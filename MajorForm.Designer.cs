namespace WindowsFormsApp1
{
    partial class MajorForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.majorListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(104, 242);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(193, 22);
            this.nameBox.TabIndex = 48;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(104, 215);
            this.idBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(193, 22);
            this.idBox.TabIndex = 47;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(193, 277);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(79, 28);
            this.deleteButton.TabIndex = 46;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteMajor_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(107, 277);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(79, 28);
            this.updateButton.TabIndex = 45;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateMajor_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(20, 277);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(79, 28);
            this.addButton.TabIndex = 44;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addMajor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Id";
            // 
            // majorListBox
            // 
            this.majorListBox.FormattingEnabled = true;
            this.majorListBox.ItemHeight = 16;
            this.majorListBox.Location = new System.Drawing.Point(16, 47);
            this.majorListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.majorListBox.Name = "majorListBox";
            this.majorListBox.Size = new System.Drawing.Size(281, 164);
            this.majorListBox.TabIndex = 39;
            this.majorListBox.SelectedIndexChanged += new System.EventHandler(this.majorBox_SelectedIndexChanged);
            // 
            // MajorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 315);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.majorListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MajorForm";
            this.Text = "MajorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox majorListBox;
    }
}