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

namespace UniversityManagmentTbiApp
{
    public partial class UnassignCoursesForm : Form
    {
        public UnassignCoursesForm()
        {
            InitializeComponent();
        }

        private void unassignAllTeacherFromCourseButton_Click(object sender, EventArgs e)
        {
            CourseAssignToTeacherManager courseAssignToTeacherManager = new CourseAssignToTeacherManager();

            string massage = courseAssignToTeacherManager.UnassignTeacherFromCourse();
            MessageBox.Show(massage);
        }
    }
}
