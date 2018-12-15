namespace UniversityManagmentTbiApp
{
    partial class UnassignCoursesForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.unassignAllTeacherFromCourseButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.unassignAllTeacherFromCourseButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(128, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 122);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unassign All Courses";
            // 
            // unassignAllTeacherFromCourseButton
            // 
            this.unassignAllTeacherFromCourseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.unassignAllTeacherFromCourseButton.Location = new System.Drawing.Point(22, 60);
            this.unassignAllTeacherFromCourseButton.Name = "unassignAllTeacherFromCourseButton";
            this.unassignAllTeacherFromCourseButton.Size = new System.Drawing.Size(369, 37);
            this.unassignAllTeacherFromCourseButton.TabIndex = 0;
            this.unassignAllTeacherFromCourseButton.Text = "Unassign All Teachers From course";
            this.unassignAllTeacherFromCourseButton.UseVisualStyleBackColor = true;
            this.unassignAllTeacherFromCourseButton.Click += new System.EventHandler(this.unassignAllTeacherFromCourseButton_Click);
            // 
            // UnassignCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 399);
            this.Controls.Add(this.groupBox2);
            this.Name = "UnassignCoursesForm";
            this.Text = "UnassignCoursesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button unassignAllTeacherFromCourseButton;
    }
}