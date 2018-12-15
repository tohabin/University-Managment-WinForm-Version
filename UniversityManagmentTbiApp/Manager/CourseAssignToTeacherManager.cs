using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagmentTbiApp.Getway;
using UniversityManagmentTbiApp.Model;

namespace UniversityManagmentTbiApp.Manager
{
    class CourseAssignToTeacherManager
    {
        private CourseAssignToTeacherGetway courseAssignToTeacherGetway;

        public CourseAssignToTeacherManager()
        {
            courseAssignToTeacherGetway = new CourseAssignToTeacherGetway();
        }


        public string SaveCourseAssignToTeacher(CourseAssignToTeacher courseAssignToTeacher)
        {
            int rowEffected = courseAssignToTeacherGetway.SaveCourseAssignToTeacher(courseAssignToTeacher);

            if (rowEffected > 0)
            {
                return "Successfully Save";
            }

            else
            {
                return "Failed Save";
            }
        }

        public string UnassignTeacherFromCourse()
        {
            int rowEffected = courseAssignToTeacherGetway.UnassignTeacherFromCourse();

            if (rowEffected > 0)
            {
                return "Successfully unassign";
            }

            else
            {
                return "Nothing To unassign";
            }
        }

        public bool IsExistCourse(CourseAssignToTeacher courseAssignToTeacher)
        {
            return courseAssignToTeacherGetway.IsExistCourse(courseAssignToTeacher);

        }

        public List<CourseAssignToTeacher> GetAllCourseAssignToTeachers(int deptId)
        {
            return courseAssignToTeacherGetway.GetAllCourseAssignToTeachers(deptId);
        }


        
    }
}
