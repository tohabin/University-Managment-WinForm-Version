namespace UniversityManagmentTbiApp
{
    partial class CourseAssignToTeacherForm
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
            this.creditToBeTakenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.remainingCreditTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.assignButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.teachereComboBox = new System.Windows.Forms.ComboBox();
            this.hiddenLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.courseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.refreshListButton = new System.Windows.Forms.Button();
            this.hiddenTeacherId = new System.Windows.Forms.Label();
            this.hiddenCourseId = new System.Windows.Forms.Label();
            this.hiddenDeptId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // creditToBeTakenTextBox
            // 
            this.creditToBeTakenTextBox.Location = new System.Drawing.Point(137, 116);
            this.creditToBeTakenTextBox.Name = "creditToBeTakenTextBox";
            this.creditToBeTakenTextBox.ReadOnly = true;
            this.creditToBeTakenTextBox.Size = new System.Drawing.Size(253, 24);
            this.creditToBeTakenTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credit To be taken";
            // 
            // remainingCreditTextBox
            // 
            this.remainingCreditTextBox.Location = new System.Drawing.Point(137, 143);
            this.remainingCreditTextBox.Name = "remainingCreditTextBox";
            this.remainingCreditTextBox.ReadOnly = true;
            this.remainingCreditTextBox.Size = new System.Drawing.Size(253, 24);
            this.remainingCreditTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remaining Credit";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(137, 205);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(253, 24);
            this.nameTextBox.TabIndex = 4;
            // 
            // creditTextBox
            // 
            this.creditTextBox.Location = new System.Drawing.Point(137, 235);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.ReadOnly = true;
            this.creditTextBox.Size = new System.Drawing.Size(253, 24);
            this.creditTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Credit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Department";
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(279, 265);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(111, 38);
            this.assignButton.TabIndex = 12;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Teacher";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(137, 52);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(253, 26);
            this.departmentComboBox.TabIndex = 20;
            this.departmentComboBox.SelectionChangeCommitted += new System.EventHandler(this.departmentComboBox_SelectionChangeCommitted);
            // 
            // teachereComboBox
            // 
            this.teachereComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teachereComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teachereComboBox.FormattingEnabled = true;
            this.teachereComboBox.Location = new System.Drawing.Point(137, 84);
            this.teachereComboBox.Name = "teachereComboBox";
            this.teachereComboBox.Size = new System.Drawing.Size(253, 26);
            this.teachereComboBox.TabIndex = 20;
            this.teachereComboBox.SelectionChangeCommitted += new System.EventHandler(this.teachereComboBox_SelectionChangeCommitted);
            // 
            // hiddenLabel
            // 
            this.hiddenLabel.AutoSize = true;
            this.hiddenLabel.Enabled = false;
            this.hiddenLabel.Location = new System.Drawing.Point(604, 17);
            this.hiddenLabel.Name = "hiddenLabel";
            this.hiddenLabel.Size = new System.Drawing.Size(21, 18);
            this.hiddenLabel.TabIndex = 21;
            this.hiddenLabel.Text = "-1";
            this.hiddenLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Course Code";
            // 
            // courseCodeComboBox
            // 
            this.courseCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseCodeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.courseCodeComboBox.FormattingEnabled = true;
            this.courseCodeComboBox.Location = new System.Drawing.Point(137, 173);
            this.courseCodeComboBox.Name = "courseCodeComboBox";
            this.courseCodeComboBox.Size = new System.Drawing.Size(253, 26);
            this.courseCodeComboBox.TabIndex = 23;
            this.courseCodeComboBox.SelectionChangeCommitted += new System.EventHandler(this.courseCodeComboBox_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseCodeComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.hiddenLabel);
            this.groupBox1.Controls.Add(this.teachereComboBox);
            this.groupBox1.Controls.Add(this.departmentComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.assignButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.creditTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.remainingCreditTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.creditToBeTakenTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 340);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Assign To Teacher";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(297, 495);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 38);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // refreshListButton
            // 
            this.refreshListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshListButton.Location = new System.Drawing.Point(12, 495);
            this.refreshListButton.Name = "refreshListButton";
            this.refreshListButton.Size = new System.Drawing.Size(279, 38);
            this.refreshListButton.TabIndex = 7;
            this.refreshListButton.Text = "Refresh List";
            this.refreshListButton.UseVisualStyleBackColor = true;
            this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click);
            // 
            // hiddenTeacherId
            // 
            this.hiddenTeacherId.AutoSize = true;
            this.hiddenTeacherId.Location = new System.Drawing.Point(38, 394);
            this.hiddenTeacherId.Name = "hiddenTeacherId";
            this.hiddenTeacherId.Size = new System.Drawing.Size(16, 13);
            this.hiddenTeacherId.TabIndex = 8;
            this.hiddenTeacherId.Text = "-1";
            this.hiddenTeacherId.Visible = false;
            // 
            // hiddenCourseId
            // 
            this.hiddenCourseId.AutoSize = true;
            this.hiddenCourseId.Location = new System.Drawing.Point(38, 420);
            this.hiddenCourseId.Name = "hiddenCourseId";
            this.hiddenCourseId.Size = new System.Drawing.Size(16, 13);
            this.hiddenCourseId.TabIndex = 9;
            this.hiddenCourseId.Text = "-1";
            this.hiddenCourseId.Visible = false;
            // 
            // hiddenDeptId
            // 
            this.hiddenDeptId.AutoSize = true;
            this.hiddenDeptId.Location = new System.Drawing.Point(38, 449);
            this.hiddenDeptId.Name = "hiddenDeptId";
            this.hiddenDeptId.Size = new System.Drawing.Size(16, 13);
            this.hiddenDeptId.TabIndex = 10;
            this.hiddenDeptId.Text = "-1";
            this.hiddenDeptId.Visible = false;
            // 
            // CourseAssignToTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 545);
            this.Controls.Add(this.hiddenDeptId);
            this.Controls.Add(this.hiddenCourseId);
            this.Controls.Add(this.hiddenTeacherId);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.refreshListButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "CourseAssignToTeacherForm";
            this.Text = "CourseAssignToTeacherForm";
            this.Load += new System.EventHandler(this.CourseAssignToTeacherForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox creditToBeTakenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox remainingCreditTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox creditTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.ComboBox teachereComboBox;
        private System.Windows.Forms.Label hiddenLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox courseCodeComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button refreshListButton;
        private System.Windows.Forms.Label hiddenTeacherId;
        private System.Windows.Forms.Label hiddenCourseId;
        private System.Windows.Forms.Label hiddenDeptId;

    }
}