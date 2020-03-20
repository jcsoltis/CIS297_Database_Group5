namespace WindowsFormsApp1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDataSet = new WindowsFormsApp1.CollegeDataSet();
            this.courseTableAdapter = new WindowsFormsApp1.CollegeDataSetTableAdapters.CourseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Course Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CourseForm_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Enrollment Form";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.EnrollmentForm_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Instructor Form";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.InstructorForm_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(41, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "Major Form";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.MajorForm_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(41, 240);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "Section Form";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SectionForm_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(41, 299);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 30);
            this.button7.TabIndex = 7;
            this.button7.Text = "Student Form";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.StudentForm_Click);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.collegeDataSet;
            // 
            // collegeDataSet
            // 
            this.collegeDataSet.DataSetName = "CollegeDataSet";
            this.collegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 347);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private CollegeDataSet collegeDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private CollegeDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
    }
}

