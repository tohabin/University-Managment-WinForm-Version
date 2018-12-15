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
    public partial class ViewStudentForm : Form
    {
        private StudentManager _studentManager;
        public ViewStudentForm()
        {
            InitializeComponent();
            _studentManager = new StudentManager();

        }

        private void ViewStudentForm_Load(object sender, EventArgs e)
        {
            //Load the list view
            PopulateListView();
        }
       
        
        public void PopulateListView()
        {

            // atfirst clear what ever it has
            studentListView.Items.Clear();


            //then load the listview
            List<StudentWithDepartmentViewModel> students = _studentManager.GetAllStudents();

            foreach (StudentWithDepartmentViewModel aStudent in students)
            {
                ListViewItem item = new ListViewItem();

                item.Text = aStudent.RegistraionNo;

                item.SubItems.Add(aStudent.StudentName);
                item.SubItems.Add(aStudent.Email);
                item.SubItems.Add(aStudent.ContactNo);
                item.SubItems.Add(aStudent.Date.ToString("d"));
                item.SubItems.Add(aStudent.Address);
                item.SubItems.Add(aStudent.Code);
                item.Tag = aStudent;

                studentListView.Items.Add(item);
            }
        }
    }
}
