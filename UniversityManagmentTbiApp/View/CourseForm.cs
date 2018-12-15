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
    public partial class CourseForm : Form
    {
        private MainForm mainForm;
        private CourseManager courseManager;
        public CourseForm()
        {
            InitializeComponent();
            courseManager = new CourseManager();
        }
        public CourseForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            courseManager = new CourseManager();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            // Fill department Combobox
            //Load the combobox

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


            // filling the semester combobox

            List<string> semesterList = new List<string>
            {
                "---Select---","1st", "2nd", "3rd", "4th", "5th", "6th", "7th", "8th"
            };


            semesterComboBox.DataSource = semesterList;



        }
        
        // UI Buttons
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            //if --->validaton check
            if (Convert.ToInt32(departmentComboBox.SelectedValue) == -1 || semesterComboBox.SelectedValue.ToString().Equals("---Select---"))
            {
                MessageBox.Show(@"Please insert All Feild");
                return;
            }
            Course course = new Course();

            course.Code = codeTextBox.Text;
            course.Name = nameTextBox.Text;
            course.Credit = float.Parse(creditTextBox.Text);
            course.Description = descriptionTextBox.Text;
            course.DeptId = (int) departmentComboBox.SelectedValue;
            course.Semester = semesterComboBox.SelectedValue.ToString();

            string massage = courseManager.SaveCourse(course);
            MessageBox.Show(massage);



        }

        

       
    }
}
