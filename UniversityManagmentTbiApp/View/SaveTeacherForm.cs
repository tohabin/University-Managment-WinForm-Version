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
using UniversityManagmentTbiApp.View;

namespace UniversityManagmentTbiApp
{
    public partial class SaveTeacherForm : Form
    {
        private MainForm mainForm;
        private ViewTeacherForm viewTeacherForm;

        public SaveTeacherForm()
        {
            InitializeComponent();
        }


        public SaveTeacherForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
        private void SaveTeacherForm_Load(object sender, EventArgs e)
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


            // fill desgantion Combobox
            List<string> desgnationList = new List<string>
            {
                "---Select---",
                "Lecturer",
                "Assistant Professor",
                "Assositate Professor",
                "Professor"
            };

            designationComboBox.DataSource = desgnationList;


        }


        private void saveButton_Click(object sender, EventArgs e)
        {

            //if --->validaton check
            if (Convert.ToInt32(departmentComboBox.SelectedValue) == -1 || designationComboBox.SelectedValue.ToString().Equals("---Select---"))
            {
                MessageBox.Show(@"Please insert All Feild");
                return;
            }


            Teacher teacher = new Teacher();

            teacher.Name = nameTextBox.Text;
            teacher.Address = addressTextBox.Text;
            teacher.Email = emailTextBox.Text;
            teacher.Contact = contactNoTextBox.Text;
            teacher.DeptId = Convert.ToInt32(departmentComboBox.SelectedValue);
            teacher.Designation = designationComboBox.SelectedValue.ToString();
            teacher.CreditToBeTaken = float.Parse(creditToBeTakenTextBox.Text);

            TeacherManager teacherManager = new TeacherManager();

            string massage = teacherManager.SaveTeacher(teacher);

            MessageBox.Show(massage);

        }

        private void refreshListButton_Click(object sender, EventArgs e)
        {
            // switch to view all students Form
            if (viewTeacherForm == null)
            {


                if (mainForm == null)
                {
                    mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    mainForm.Activate();
                }

                viewTeacherForm = new ViewTeacherForm();
                viewTeacherForm.MdiParent = mainForm;

                viewTeacherForm.FormClosed += delegate(object o, FormClosedEventArgs args) { viewTeacherForm = null; };
                viewTeacherForm.Show();

            }

            else
            {
                viewTeacherForm.Activate();
                //viewTeacherForm.PopulateListView();
            }

        }




    }
}
