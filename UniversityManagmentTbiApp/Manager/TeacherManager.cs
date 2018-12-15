using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagmentTbiApp.Getway;
using UniversityManagmentTbiApp.Model;

namespace UniversityManagmentTbiApp.Manager
{
    class TeacherManager
    {
        private TeacherGetway teacherGetway;

        public TeacherManager()
        {
            teacherGetway = new TeacherGetway();
        }
        public string SaveTeacher(Teacher teacher)
        {
            
            int rowEffected = teacherGetway.SaveTeacherForm(teacher);

            if (rowEffected > 0)
            {
                return "Successfully Save";
            }
            else
            {
                return "Fail Save";
            }
        }

        public List<TeacherWithDepartmentViewModel> GetAllTeacherWithDepartment(int deptId)
        {
            
            return teacherGetway.GetAllTeacherWithDepartment(deptId);
        }

        public Teacher GetATeacher(int teacherId)
        {
            return teacherGetway.GetATeacher(teacherId);
        }
    }
}
