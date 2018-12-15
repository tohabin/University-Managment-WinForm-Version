using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManagmentTbiApp.View;

namespace UniversityManagmentTbiApp
{
    public partial class MainForm : Form
    {
        //course
        private CourseForm courseForm;
        private UnassignCoursesForm unassignCoursesForm;
        private CourseAssignToTeacherForm courseAssignToTeacherForm;
        //teacher
        private SaveTeacherForm saveTeacherForm;
        private ViewTeacherForm viewTeacherForm;
        //class schedule
        private AllocateClassRoomForm allocateClassRoomForm;
        private ViewClassScheduleForm viewClassScheduleForm;
        private UnallocateClassRoomsForm unallocateClassRoomsForm;
        private CourseStatisticsForm courseStatisticsForm;
        //student
        private ViewStudentForm viewStudentForm;
        private RegisterStudentForm registerStudentForm;
        private EnrollInCourseForm enrollInCourseForm;
        private ViewResultForm viewResultForm;
        private SaveStudentResultForm saveStudentResultForm;
        //department
        private DepartmentForm departmentForm;
        private ViewDepartmentForm viewDepartmentForm;
        
        public MainForm()
        {
            InitializeComponent();
        }

       
        // -----------------------------department---------------------------------
        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewDepartmentForm == null)
            {
                viewDepartmentForm = new ViewDepartmentForm();
                viewDepartmentForm.MdiParent = this;

                viewDepartmentForm.FormClosed += delegate(object o, FormClosedEventArgs args) { viewDepartmentForm = null; };
                viewDepartmentForm.Show();
            }

            else
            {
                viewDepartmentForm.Activate();
            }

            
        }

        private void newToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Add new department
            if (departmentForm == null)
            {
                departmentForm = new DepartmentForm(this);

                departmentForm.FormClosed += delegate(object o, FormClosedEventArgs args) { departmentForm = null; };
                departmentForm.Show();
            }

            else
            {
                departmentForm.Activate();
            }
            

        }

        

        private void enrollInCourseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // allocate class room
            if (enrollInCourseForm == null)
            {
                enrollInCourseForm = new EnrollInCourseForm();

                enrollInCourseForm.FormClosed += delegate(object o, FormClosedEventArgs args) { enrollInCourseForm = null; };
                enrollInCourseForm.Show();
            }

            else
            {
                enrollInCourseForm.Activate();
            }


        }

        private void addToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //-----------------save student result-------------------------//
            if (saveStudentResultForm == null)
            {
                saveStudentResultForm = new SaveStudentResultForm();

                saveStudentResultForm.FormClosed += delegate(object o, FormClosedEventArgs args) { saveStudentResultForm = null; };
                saveStudentResultForm.Show();
            }

            else
            {
                saveStudentResultForm.Activate();
            }
            
        }

        private void viewToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (viewResultForm == null)
            {
                viewResultForm = new ViewResultForm();
                viewResultForm.MdiParent = this;

                viewResultForm.FormClosed += delegate(object o, FormClosedEventArgs args) { viewResultForm = null; };
                viewResultForm.Show();
            }

            else
            {
                viewResultForm.Activate();
            }

            
        }


        //-------------------- class schedule------------------------------------------------------
        private void allocateRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // allocate class room
            if (allocateClassRoomForm == null)
            {
                allocateClassRoomForm = new AllocateClassRoomForm();

                allocateClassRoomForm.FormClosed += delegate(object o, FormClosedEventArgs args) { allocateClassRoomForm = null; };
                allocateClassRoomForm.Show();
            }

            else
            {
                allocateClassRoomForm.Activate();
            }

        }

        private void viewRotineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // view class schedule
            if (viewClassScheduleForm == null)
            {
                viewClassScheduleForm = new ViewClassScheduleForm();
                viewClassScheduleForm.MdiParent = this;

                viewClassScheduleForm.FormClosed += delegate(object o, FormClosedEventArgs args) { viewClassScheduleForm = null; };
                viewClassScheduleForm.Show();
            }

            else
            {
                viewClassScheduleForm.Activate();
            }

        }

        private void unallocateAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unallocateClassRoomsForm == null)
            {
                unallocateClassRoomsForm = new UnallocateClassRoomsForm();
                unallocateClassRoomsForm.MdiParent = this;

                unallocateClassRoomsForm.FormClosed += delegate(object o, FormClosedEventArgs args){ unallocateClassRoomsForm = null; };

                unallocateClassRoomsForm.Show();
            }
            else
            {
                unallocateClassRoomsForm.Activate();
            }
 
        }

        
        //------------------------Teacher-----------------------------------//
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save teacher form
            
            if (saveTeacherForm == null)
            {
                saveTeacherForm = new SaveTeacherForm(this);

                saveTeacherForm.FormClosed += delegate(object o, FormClosedEventArgs args) { saveTeacherForm = null; };
                saveTeacherForm.Show();
            }

            else
            {
                saveTeacherForm.Activate();
            }

        }

        private void viewAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // view all teachers
            if (viewTeacherForm == null)
            {
                viewTeacherForm = new ViewTeacherForm();
                viewTeacherForm.MdiParent = this;

                viewTeacherForm.FormClosed += delegate(object o, FormClosedEventArgs args) { viewTeacherForm = null; };
                viewTeacherForm.Show();
            }

            else
            {
                
                viewTeacherForm.Activate();
            }

        }

        //-------------------------------- Course----------------------------------//
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // course add new
            if (courseForm == null)
            {
                courseForm = new CourseForm(this);

                courseForm.FormClosed += delegate(object o, FormClosedEventArgs args) { courseForm = null; };
                courseForm.Show();
            }

            else
            {
                courseForm.Activate();
            }
        }


        //private void viewCourseScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //view course schedule
        //    if (viewClassScheduleForm == null)
        //    {
        //        viewClassScheduleForm = new ViewClassScheduleForm();
        //        viewClassScheduleForm.MdiParent = this;

        //        viewClassScheduleForm.FormClosed += delegate(object o, FormClosedEventArgs args)
        //        {
        //            viewClassScheduleForm = null;
        //        };

        //        viewClassScheduleForm.Show();
        //    }
        //    else
        //    {
        //        viewClassScheduleForm.Activate();
        //    }
        //}
        private void courseStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //view course schedule
                if (courseStatisticsForm  == null)
                {
                    courseStatisticsForm = new CourseStatisticsForm();
                    courseStatisticsForm.MdiParent = this;

                    courseStatisticsForm.FormClosed += delegate(object o, FormClosedEventArgs args)
                    {
                        courseStatisticsForm = null;
                    };

                    courseStatisticsForm.Show();
                }
                else
                {
                    courseStatisticsForm.Activate();
                }

        }

        private void unassignAllTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //un assgin all courses
            if (unassignCoursesForm == null)
            {
                unassignCoursesForm = new UnassignCoursesForm();
                unassignCoursesForm.MdiParent = this;

                unassignCoursesForm.FormClosed += delegate(object o, FormClosedEventArgs args) { unassignCoursesForm = null; };
                unassignCoursesForm.Show();
            }

            else
            {
                unassignCoursesForm.Activate();
            }

        }

        private void assignATeacherToCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (courseAssignToTeacherForm == null)
            {
                courseAssignToTeacherForm = new CourseAssignToTeacherForm(this);

                courseAssignToTeacherForm.FormClosed += delegate(object o, FormClosedEventArgs args) { courseAssignToTeacherForm = null; };
                courseAssignToTeacherForm.Show();
            }

            else
            {
                courseAssignToTeacherForm.Activate();
            }

        }


        // ---------------------Students---------------------------------------------------
        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //register student form
            if (registerStudentForm == null)
            {
                registerStudentForm = new RegisterStudentForm(this);

                registerStudentForm.FormClosed += delegate(object o, FormClosedEventArgs args) { registerStudentForm = null; };
                registerStudentForm.Show();
            }

            else
            {
                registerStudentForm.Activate();
            }

        }
        private void viewAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // view all students
            if (viewStudentForm == null)
            {
                viewStudentForm = new ViewStudentForm();
                viewStudentForm.MdiParent = this;

                viewStudentForm.FormClosed += delegate(object o, FormClosedEventArgs args) { viewStudentForm = null; };
                viewStudentForm.Show();

            }

            else
            {
                viewStudentForm.Activate();
                viewStudentForm.PopulateListView();
            }

        }

        

        
    }
}
