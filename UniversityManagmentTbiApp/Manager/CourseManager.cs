using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagmentTbiApp.Getway;
using UniversityManagmentTbiApp.Model;

namespace UniversityManagmentTbiApp.Manager
{
    class CourseManager
    {
        private CourseGetway courseGetway;

        public CourseManager()
        {
            courseGetway = new CourseGetway();
        }

        public string SaveCourse(Course course)
        {
            int rowEffected = courseGetway.SaveCourse(course);

            if (rowEffected > 0)
            {
                return "Successfully saved";
            }

            else
            {
                return "Failed save";
            }

        }

        public List<Course> GetAllCourses(int deptId)
        {
            return courseGetway.GetAllCourse(deptId);
        }

        public Course GetACourse(int courseId)
        {
            return courseGetway.GetACourse(courseId);
        }
    }
}
