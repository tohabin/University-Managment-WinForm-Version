using System;
using System.CodeDom.Compiler;
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
    public partial class RegisterStudentForm : Form
    {
        private StudentManager _studentManager;
        private DepartmentManager _departmentManager;
        private ViewStudentForm viewStudentForm;
        private MainForm mainForm;
        private Student StudentObjectToOrFromUi
        {
            get
            {
                Student aStudent = new Student
                {
                    
                    Id = int.Parse(hiddenLabel.Text),
                    RegistraionNo = "",
                    Name = nameTextBox.Text,
                    Email = emailTextBox.Text,
                    ContactNo = contactNoTextBox.Text,
                    Date = DateTime.Parse(dateDateTimePicker.Text),
                    Address = addressTextBox.Text,
                    DeptId = Convert.ToInt32(departmentComboBox.SelectedValue)
                };
                return aStudent;
            }



        }

        //constructor
        public RegisterStudentForm()
        {
            _studentManager = new StudentManager();
            _departmentManager = new DepartmentManager();
            InitializeComponent();
        }
        public RegisterStudentForm(MainForm mainForm)
        {
            _studentManager = new StudentManager();
            _departmentManager = new DepartmentManager();
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void RegisterStudentForm_Load(object sender, EventArgs e)
        {

            //Load the combobox
            //------------------
            
            List<Department> departments = new List<Department>();

            //Get all real department from database
            List<Department> realDepartments = _departmentManager.GetAllDepartments();

            // add a fake --select--- option to the begining of the list
            Department fakeDepartment = new Department()
            {
                Id = -1,
                Code = "--Select--",
                Name = "--Select--"
            };

            

            // combine fake and real
            departments.Add(fakeDepartment);
            departments.AddRange(realDepartments);

            //filling the comboBox
            departmentComboBox.DataSource = departments;
            departmentComboBox.DisplayMember = "Name";
            departmentComboBox.ValueMember = "Id";


            
        }


        private void registerButton_Click(object sender, EventArgs e)
        {

            //if --->validaton check
            if (Convert.ToInt32(departmentComboBox.SelectedValue) == -1)
            {
                MessageBox.Show(@"Please insert Department");
                return;
            }

            
           
            Student student = StudentObjectToOrFromUi;

            // is email exist check
            if (_studentManager.IsExistEmail(student))
            {
                MessageBox.Show(@"Registraion NO Exist Please choose Another");
                return;
            }

            // Atuto registraion No generaion
            string registraionNo = _studentManager.RegistraionNoGneraion(student);

            string title = "Registraion NO";
            string massageboxString = "your Regisraion NO: "+registraionNo+""+"\n"+
                               "do you want to continue";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            System.Windows.Forms.DialogResult result = MessageBox.Show(massageboxString, title, buttons);

            string massage = "";
            if (result == DialogResult.Yes)
            {
                student.RegistraionNo = registraionNo;
                massage = _studentManager.RegisterStudent(student);
                
            }
            else
            {
                massage = "Registraion porcess is aborted";
            }
            
            MessageBox.Show(massage);

            //PopulateListView();
            //resetButton.Enabled = true;


        }

        private void refreshListButton_Click(object sender, EventArgs e)
        {

            // switch to view all students Form
            if (viewStudentForm == null)
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
                
                viewStudentForm = new ViewStudentForm();
                viewStudentForm.MdiParent = mainForm;

                viewStudentForm.FormClosed += delegate(object o, FormClosedEventArgs args) { viewStudentForm = null; };
                viewStudentForm.Show();

            }

            else
            {
                viewStudentForm.Activate();
                viewStudentForm.PopulateListView();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        //private void deleteButton_Click(object sender, EventArgs e)
        //{
        //    Student student = StudentObjectToOrFromUi;


        //    string massage = _studentManager.DeleteStudent(student);
        //    MessageBox.Show(massage);
            
        //    PopulateListView();
        //    EmptyBoxesAndButtons();

        //}

        //private void editButton_Click(object sender, EventArgs e)
        //{
        //    Student student = StudentObjectToOrFromUi;

        //    if (_studentManager.IsExistEmail(student))
        //    {
        //        MessageBox.Show(@"Registraion NO Exist Please choose Another");
        //        return;
        //    }


        //    string massage = _studentManager.EditStudent(student);
        //    MessageBox.Show(massage);
            
        //    PopulateListView();
            
        //}


        //private void resetButton_Click(object sender, EventArgs e)
        //{
        //    EmptyBoxesAndButtons();
        //}



        //private void studentListView_DoubleClick(object sender, EventArgs e)
        //{


        //    ListViewItem selectedItem = studentListView.SelectedItems[0];

        //    StudentWithDepartmentViewModel aStudent = selectedItem.Tag as StudentWithDepartmentViewModel;
        //    //load the boxes
        //    if (aStudent != null)
        //    {
        //        hiddenLabel.Text = aStudent.StudentId.ToString();
        //        registraionNoLabel.Text = aStudent.RegistraionNo;
        //        nameTextBox.Text = aStudent.StudentName;
        //        emailTextBox.Text = aStudent.Email;
        //        contactNoTextBox.Text = aStudent.ContactNo;
        //        dateDateTimePicker.Value = aStudent.Date;
        //        addressTextBox.Text = aStudent.Address;
        //        departmentComboBox.SelectedValue = aStudent.DepartmentId;
        //    }


        //    //buttons enable disable
        //    registerButton.Enabled = false;
        //    editButton.Enabled = true;
        //    deleteButton.Enabled = true;
        //    resetButton.Enabled = true;

        //}


       
        //private void EmptyBoxesAndButtons()
        //{
        //    //empty boxes
        //    hiddenLabel.Text = @"-1";
        //    registraionNoLabel.Text = @" Authority give you A registraion No ";
        //    nameTextBox.Clear();
        //    emailTextBox.Clear();
        //    contactNoTextBox.Clear();
        //    dateDateTimePicker.Value = DateTime.Today;
        //    addressTextBox.Clear();
        //    departmentComboBox.SelectedValue = -1;


        //    //reset button
        //    editButton.Enabled = false;
        //    deleteButton.Enabled = false;
        //    resetButton.Enabled = false;
        //    registerButton.Enabled = true;
        //}

        
        




    }
}
