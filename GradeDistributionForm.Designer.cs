﻿namespace WindowsFormsApp1
{
    partial class GradeDistributionForm
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
            this.labelForName = new System.Windows.Forms.Label();
            this.gradesLettersLabel = new System.Windows.Forms.Label();
            this.gradesPercentsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelForName
            // 
            this.labelForName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForName.Location = new System.Drawing.Point(12, 19);
            this.labelForName.Name = "labelForName";
            this.labelForName.Size = new System.Drawing.Size(355, 48);
            this.labelForName.TabIndex = 0;
            this.labelForName.Text = "label";
            this.labelForName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gradesLettersLabel
            // 
            this.gradesLettersLabel.Location = new System.Drawing.Point(149, 82);
            this.gradesLettersLabel.Name = "gradesLettersLabel";
            this.gradesLettersLabel.Size = new System.Drawing.Size(39, 281);
            this.gradesLettersLabel.TabIndex = 1;
            // 
            // gradesPercentsLabel
            // 
            this.gradesPercentsLabel.Location = new System.Drawing.Point(203, 82);
            this.gradesPercentsLabel.Name = "gradesPercentsLabel";
            this.gradesPercentsLabel.Size = new System.Drawing.Size(138, 281);
            this.gradesPercentsLabel.TabIndex = 2;
            // 
            // GradeDistributionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 392);
            this.Controls.Add(this.gradesPercentsLabel);
            this.Controls.Add(this.gradesLettersLabel);
            this.Controls.Add(this.labelForName);
            this.Name = "GradeDistributionForm";
            this.Text = "GradeDistributionForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelForName;
        private System.Windows.Forms.Label gradesLettersLabel;
        private System.Windows.Forms.Label gradesPercentsLabel;
    }
}