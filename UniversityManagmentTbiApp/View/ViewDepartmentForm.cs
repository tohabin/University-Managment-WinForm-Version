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
    public partial class ViewDepartmentForm : Form
    {

        private DepartmentManager departmentManager;


        public ViewDepartmentForm()
        {
            InitializeComponent();
            departmentManager = new DepartmentManager();

        }

        private void ViewDepartmentForm_Load(object sender, EventArgs e)
        {
            PopulateDepartmentListView();
        }


        private void PopulateDepartmentListView()
        {
            List<Department> departments = departmentManager.GetAllDepartments();

            foreach (Department department in departments)
            {
                ListViewItem item = new ListViewItem();

                // first one insert in text
                item.Text = department.Code;
                // after that all are inserted as sub item
                item.SubItems.Add(department.Name);


                // the the full row inserted in departmentlistView
                departmentListView.Items.Add(item);
            }
        }


    }
}
