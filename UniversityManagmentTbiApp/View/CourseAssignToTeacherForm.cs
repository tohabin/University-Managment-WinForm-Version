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
    public partial class CourseAssignToTeacherForm : Form
    {
        private MainForm mainForm;
        private CourseAssignToTeacherManager courseAssignToTeacherManager;
        public CourseAssignToTeacherForm()
        {
            courseAssignToTeacherManager = new CourseAssignToTeacherManager();
            InitializeComponent();
        }

        public CourseAssignToTeacherForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            courseAssignToTeacherManager = new CourseAssignToTeacherManager();
        }

        private void CourseAssignToTeacherForm_Load(object sender, EventArgs e)
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

        private void assignButton_Click(object sender, EventArgs e)
        {
            CourseAssignToTeacher courseAssignToTeacher = new CourseAssignToTeacher();
            
            
            float remainingCredit;
            float.TryParse(remainingCreditTextBox.Text, out remainingCredit);

            float courseCredit;
            float.TryParse(creditTextBox.Text, out courseCredit);

            remainingCredit -= courseCredit;
            
            
            DialogResult result = DialogResult.None;
            if (remainingCredit <= 0)
            {
                string massageBoxString = "Teacher is Assigned more Credit\n"
                                          + "Do you want to continue";
                string titleBarString = "Warning";
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
                MessageBoxIcon messageBoxIcon = MessageBoxIcon.Information;

                result = MessageBox.Show(massageBoxString, titleBarString, messageBoxButtons,
                    messageBoxIcon);

            }
            if (result == DialogResult.No)
                return;
            // erokom return condition ta 1ta choto limited condtion. mane ei jaiga projonto ashle ei condition ta mante hobe
            // na hoi program break korbe

            courseAssignToTeacher.RemainingCredit = remainingCredit;

            int deptId;
            int.TryParse(hiddenDeptId.Text, out deptId);
            courseAssignToTeacher.DeptId = deptId;

            int teacherId;
            int.TryParse(hiddenTeacherId.Text, out teacherId);
            courseAssignToTeacher.TeacherId = teacherId;

            int courseId;
            int.TryParse(hiddenCourseId.Text, out courseId);
            courseAssignToTeacher.CourseId = courseId;




            if (courseAssignToTeacherManager.IsExistCourse(courseAssignToTeacher))
            {
                MessageBox.Show(@"This Course already assign to a teacher");
                return;
            }

            string massage = courseAssignToTeacherManager.SaveCourseAssignToTeacher(courseAssignToTeacher);

            MessageBox.Show(massage);



        }


        private void refreshListButton_Click(object sender, EventArgs e)
        {
            CourseStatisticsForm courseStatisticsForm = new CourseStatisticsForm();


            if (mainForm == null)
            {
                mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                mainForm.Activate();
            }
            courseStatisticsForm.MdiParent = mainForm;

            courseStatisticsForm.Show();

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void departmentComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            // department wise teacher selection

            int deptId = (int)departmentComboBox.SelectedValue;

            TeacherManager teacherManager = new TeacherManager();

            List<TeacherWithDepartmentViewModel> realteachers = teacherManager.GetAllTeacherWithDepartment(deptId); // -1 means all


            teachereComboBox.DataSource = realteachers;
            teachereComboBox.ValueMember = "TeacherId";
            teachereComboBox.DisplayMember = "TeacherName";

            // department wise course selection
            CourseManager courseManager = new CourseManager();

            List<Course> realCourses = courseManager.GetAllCourses(deptId);

            courseCodeComboBox.DataSource = realCourses;
            courseCodeComboBox.ValueMember = "Id";
            courseCodeComboBox.DisplayMember = "Code";

            hiddenDeptId.Text = deptId.ToString();
        }

        private void teachereComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int teacherId = (int)teachereComboBox.SelectedValue;

            TeacherManager teacherManager = new TeacherManager();
            Teacher teacher = teacherManager.GetATeacher(teacherId);

            creditToBeTakenTextBox.Text = teacher.CreditToBeTaken.ToString();
            remainingCreditTextBox.Text = teacher.RemainingCredit.ToString();
            hiddenTeacherId.Text = teacherId.ToString();


        }

        private void courseCodeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int courseId = (int)courseCodeComboBox.SelectedValue;

            CourseManager courseManager = new CourseManager();
            Course course = courseManager.GetACourse(courseId);

            nameTextBox.Text = course.Name;
            creditTextBox.Text = course.Credit.ToString();
            hiddenCourseId.Text = courseId.ToString();
        }


    }
}
