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
    public partial class DepartmentForm : Form
    {
        private DepartmentManager departmentManager;
        private MainForm mainForm;
        public DepartmentForm()
        {
            InitializeComponent();
            departmentManager = new DepartmentManager();
        }
        public DepartmentForm(MainForm mainForm)
        {
            InitializeComponent();
            departmentManager = new DepartmentManager();
            this.mainForm = mainForm;
        }

        

        private void saveButton_Click(object sender, EventArgs e)
        {
            Department department = new Department();

            department.Code = codeTextBox.Text;
            department.Name = nameTextBox.Text;


            if (departmentManager.IsExistCodeName(department))
            {
                MessageBox.Show("Code OR Name already exist");
                return;
            }
            string massage = departmentManager.SaveDepartment(department);

            MessageBox.Show(massage);
            

        }


        private void refreshListButton_Click(object sender, EventArgs e)
        {
            ViewDepartmentForm viewDepartmentForm = new ViewDepartmentForm();
            

            if (mainForm == null)
            {
                mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                mainForm.Activate();
            }
            viewDepartmentForm.MdiParent = mainForm;

            viewDepartmentForm.Show();
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        
        


        
    }
}
