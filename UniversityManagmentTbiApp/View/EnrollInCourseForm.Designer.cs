namespace UniversityManagmentTbiApp
{
    partial class EnrollInCourseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.courseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hiddenLabel = new System.Windows.Forms.Label();
            this.studnetRegNoComboBox = new System.Windows.Forms.ComboBox();
            this.enrollButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.nameTakenTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.refreshListButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.courseCodeComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.hiddenLabel);
            this.groupBox1.Controls.Add(this.studnetRegNoComboBox);
            this.groupBox1.Controls.Add(this.enrollButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.departmentTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EmailtextBox);
            this.groupBox1.Controls.Add(this.nameTakenTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 330);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Enroll In Course";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 24);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // courseCodeComboBox
            // 
            this.courseCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseCodeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.courseCodeComboBox.FormattingEnabled = true;
            this.courseCodeComboBox.Location = new System.Drawing.Point(121, 180);
            this.courseCodeComboBox.Name = "courseCodeComboBox";
            this.courseCodeComboBox.Size = new System.Drawing.Size(253, 26);
            this.courseCodeComboBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Select Course";
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
            // studnetRegNoComboBox
            // 
            this.studnetRegNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studnetRegNoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studnetRegNoComboBox.FormattingEnabled = true;
            this.studnetRegNoComboBox.Location = new System.Drawing.Point(121, 60);
            this.studnetRegNoComboBox.Name = "studnetRegNoComboBox";
            this.studnetRegNoComboBox.Size = new System.Drawing.Size(253, 26);
            this.studnetRegNoComboBox.TabIndex = 20;
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(263, 242);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(111, 38);
            this.enrollButton.TabIndex = 12;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student RegNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Department";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(121, 150);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.ReadOnly = true;
            this.departmentTextBox.Size = new System.Drawing.Size(253, 24);
            this.departmentTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(121, 122);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.ReadOnly = true;
            this.EmailtextBox.Size = new System.Drawing.Size(253, 24);
            this.EmailtextBox.TabIndex = 0;
            // 
            // nameTakenTextBox
            // 
            this.nameTakenTextBox.Location = new System.Drawing.Point(121, 92);
            this.nameTakenTextBox.Name = "nameTakenTextBox";
            this.nameTakenTextBox.ReadOnly = true;
            this.nameTakenTextBox.Size = new System.Drawing.Size(253, 24);
            this.nameTakenTextBox.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(297, 495);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 38);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // refreshListButton
            // 
            this.refreshListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshListButton.Location = new System.Drawing.Point(12, 495);
            this.refreshListButton.Name = "refreshListButton";
            this.refreshListButton.Size = new System.Drawing.Size(279, 38);
            this.refreshListButton.TabIndex = 11;
            this.refreshListButton.Text = "Refresh List";
            this.refreshListButton.UseVisualStyleBackColor = true;
            // 
            // EnrollInCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 545);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.refreshListButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "EnrollInCourseForm";
            this.Text = "EnrollInCourseForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox courseCodeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label hiddenLabel;
        private System.Windows.Forms.ComboBox studnetRegNoComboBox;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox nameTakenTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button refreshListButton;
    }
}