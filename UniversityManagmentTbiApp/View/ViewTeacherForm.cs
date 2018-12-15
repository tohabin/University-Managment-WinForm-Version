using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using UniversityManagmentTbiApp.Manager;
using UniversityManagmentTbiApp.Model;

namespace UniversityManagmentTbiApp.View
{
    public partial class ViewTeacherForm : Form
    {
        private TeacherManager teacherManager;
        private int deptId;
        public ViewTeacherForm()
        {
            InitializeComponent();
            teacherManager = new TeacherManager();
        }

        private void ViewTeacherForm_Load(object sender, EventArgs e)
        {
            DepartmentManager departmentManager = new DepartmentManager();

            //Load the combobox
            //------------------

            List<Department> departments = new List<Department>();

            //Get all real department from database
            List<Department> realDepartments = departmentManager.GetAllDepartments();

            // add a fake --select--- option to the begining of the list
            Department fakeDepartment = new Department()
            {
                Id = -1,
                Code = "--Select All--",
                Name = "--Select All--"
            };



            // combine fake and real
            departments.Add(fakeDepartment);
            departments.AddRange(realDepartments);

            //filling the comboBox
            departmentComboBox.DataSource = departments;
            departmentComboBox.DisplayMember = "Name";
            departmentComboBox.ValueMember = "Id";
            
            PopulateTeacherListView(-1);
            

        }

        

        private void PopulateTeacherListView(int departmentId)
        {
            teacherListView.Items.Clear();
            List<TeacherWithDepartmentViewModel> teachers = teacherManager.GetAllTeacherWithDepartment(departmentId);

            foreach (TeacherWithDepartmentViewModel teacher in teachers)
            {
                ListViewItem item = new ListViewItem();

                item.Text = teacher.TeacherName;


                item.SubItems.Add(teacher.Address);
                item.SubItems.Add(teacher.Email);
                item.SubItems.Add(teacher.Contact);
                item.SubItems.Add(teacher.Code);
                item.SubItems.Add(teacher.Designation);
                item.SubItems.Add(teacher.CreditToBeTaken.ToString(CultureInfo.InvariantCulture));

                teacherListView.Items.Add(item);
            }
        }

        private void departmentComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            deptId = int.Parse(departmentComboBox.SelectedValue.ToString());
            PopulateTeacherListView(deptId);
        }
    }
}
