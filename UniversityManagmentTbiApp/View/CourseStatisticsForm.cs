using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManagmentTbiApp.Manager;
using UniversityManagmentTbiApp.Model;

namespace UniversityManagmentTbiApp
{
    public partial class CourseStatisticsForm : Form
    {
        public CourseStatisticsForm()
        {
            InitializeComponent();
        }

        private void CourseStatisticsForm_Load(object sender, EventArgs e)
        {
            List<Department> departments = new List<Department>();


            // add a fake --select--- option to the begining of the list
            Department fakeDepartment = new Department()
            {
                Id = -1,
                Code = "--Select--",
                Name = "--Select--"
            };
            DepartmentManager departmentManager = new DepartmentManager();
            List<Department> realDepartments = departmentManager.GetAllDepartments();


            departments.Add(fakeDepartment);
            departments.AddRange(realDepartments);

            //filling the comboBox
            departmentComboBox.DataSource = departments;
            departmentComboBox.DisplayMember = "Name";
            departmentComboBox.ValueMember = "Id";

        }

        private void departmentComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int deptId = (int)departmentComboBox.SelectedValue;
            PopulateCourseInformationView(deptId);

        }

        private void PopulateCourseInformationView(int deptId)
        {
            courseInformationListView.Items.Clear();
            CourseAssignToTeacherManager courseAssignToTeacherManager = new CourseAssignToTeacherManager();
            List<CourseAssignToTeacher> courseAssignToTeachers =
                courseAssignToTeacherManager.GetAllCourseAssignToTeachers(deptId);

            foreach (CourseAssignToTeacher courseAssignToTeacher in courseAssignToTeachers)
            {
                ListViewItem item = new ListViewItem();

                item.Text = courseAssignToTeacher.CourseCode;


                item.SubItems.Add(courseAssignToTeacher.CourseName);
                item.SubItems.Add(courseAssignToTeacher.Semester);
                item.SubItems.Add(courseAssignToTeacher.TeacherName);
                
                courseInformationListView.Items.Add(item);
            }
        }


    }
}
