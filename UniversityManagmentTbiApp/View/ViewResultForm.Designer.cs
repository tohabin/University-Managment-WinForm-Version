namespace UniversityManagmentTbiApp
{
    partial class ViewResultForm
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
            this.makePdfButton = new System.Windows.Forms.Button();
            this.studnetRegNoComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.nameTakenTextBox = new System.Windows.Forms.TextBox();
            this.studentListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.makePdfButton);
            this.groupBox2.Controls.Add(this.studnetRegNoComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.departmentTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.EmailtextBox);
            this.groupBox2.Controls.Add(this.nameTakenTextBox);
            this.groupBox2.Controls.Add(this.studentListView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 446);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Class Schedule And Room Allocation";
            // 
            // makePdfButton
            // 
            this.makePdfButton.Location = new System.Drawing.Point(389, 168);
            this.makePdfButton.Name = "makePdfButton";
            this.makePdfButton.Size = new System.Drawing.Size(106, 31);
            this.makePdfButton.TabIndex = 29;
            this.makePdfButton.Text = "Make pdf";
            this.makePdfButton.UseVisualStyleBackColor = true;
            // 
            // studnetRegNoComboBox
            // 
            this.studnetRegNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studnetRegNoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.studnetRegNoComboBox.FormattingEnabled = true;
            this.studnetRegNoComboBox.Location = new System.Drawing.Point(242, 47);
            this.studnetRegNoComboBox.Name = "studnetRegNoComboBox";
            this.studnetRegNoComboBox.Size = new System.Drawing.Size(253, 26);
            this.studnetRegNoComboBox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Student RegNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Department";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(242, 137);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.ReadOnly = true;
            this.departmentTextBox.Size = new System.Drawing.Size(253, 24);
            this.departmentTextBox.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(242, 109);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.ReadOnly = true;
            this.EmailtextBox.Size = new System.Drawing.Size(253, 24);
            this.EmailtextBox.TabIndex = 21;
            // 
            // nameTakenTextBox
            // 
            this.nameTakenTextBox.Location = new System.Drawing.Point(242, 79);
            this.nameTakenTextBox.Name = "nameTakenTextBox";
            this.nameTakenTextBox.ReadOnly = true;
            this.nameTakenTextBox.Size = new System.Drawing.Size(253, 24);
            this.nameTakenTextBox.TabIndex = 22;
            // 
            // studentListView
            // 
            this.studentListView.AutoArrange = false;
            this.studentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader1});
            this.studentListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentListView.FullRowSelect = true;
            this.studentListView.GridLines = true;
            this.studentListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.studentListView.Location = new System.Drawing.Point(100, 215);
            this.studentListView.MultiSelect = false;
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(451, 195);
            this.studentListView.TabIndex = 0;
            this.studentListView.UseCompatibleStateImageBehavior = false;
            this.studentListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Course Code";
            this.columnHeader5.Width = 124;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 252;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Grade";
            this.columnHeader1.Width = 70;
            // 
            // ViewResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 538);
            this.Controls.Add(this.groupBox2);
            this.Name = "ViewResultForm";
            this.Text = "ViewResultForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView studentListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button makePdfButton;
        private System.Windows.Forms.ComboBox studnetRegNoComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox nameTakenTextBox;
    }
}