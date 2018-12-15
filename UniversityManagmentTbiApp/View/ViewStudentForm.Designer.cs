namespace UniversityManagmentTbiApp
{
    partial class ViewStudentForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.studentListView = new System.Windows.Forms.ListView();
            this.registrationNoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.departmentColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.studentListView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 260);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Students";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(485, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "*** Edit / Delete: Double Click To Select an Student for Edit and Delete***";
            // 
            // studentListView
            // 
            this.studentListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.studentListView.AutoArrange = false;
            this.studentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.registrationNoColumnHeader,
            this.nameColumnHeader,
            this.emailColumnHeader,
            this.contactColumnHeader,
            this.dateColumnHeader,
            this.addressColumnHeader,
            this.departmentColumnHeader1});
            this.studentListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentListView.FullRowSelect = true;
            this.studentListView.GridLines = true;
            this.studentListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.studentListView.Location = new System.Drawing.Point(8, 24);
            this.studentListView.MultiSelect = false;
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(734, 209);
            this.studentListView.TabIndex = 0;
            this.studentListView.UseCompatibleStateImageBehavior = false;
            this.studentListView.View = System.Windows.Forms.View.Details;
            // 
            // registrationNoColumnHeader
            // 
            this.registrationNoColumnHeader.Text = "RegistrationNo";
            this.registrationNoColumnHeader.Width = 95;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 84;
            // 
            // emailColumnHeader
            // 
            this.emailColumnHeader.Text = "Email";
            this.emailColumnHeader.Width = 107;
            // 
            // contactColumnHeader
            // 
            this.contactColumnHeader.Text = "Contact";
            this.contactColumnHeader.Width = 118;
            // 
            // dateColumnHeader
            // 
            this.dateColumnHeader.Text = "Date";
            this.dateColumnHeader.Width = 80;
            // 
            // addressColumnHeader
            // 
            this.addressColumnHeader.Text = "Address";
            this.addressColumnHeader.Width = 94;
            // 
            // departmentColumnHeader1
            // 
            this.departmentColumnHeader1.Text = "Department";
            this.departmentColumnHeader1.Width = 105;
            // 
            // ViewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 499);
            this.Controls.Add(this.groupBox2);
            this.Name = "ViewStudentForm";
            this.Text = "ViewStudentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewStudentForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView studentListView;
        private System.Windows.Forms.ColumnHeader registrationNoColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader emailColumnHeader;
        private System.Windows.Forms.ColumnHeader contactColumnHeader;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
        private System.Windows.Forms.ColumnHeader addressColumnHeader;
        private System.Windows.Forms.ColumnHeader departmentColumnHeader1;
    }
}