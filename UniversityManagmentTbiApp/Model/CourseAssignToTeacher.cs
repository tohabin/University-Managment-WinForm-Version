using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagmentTbiApp.Model
{
    class CourseAssignToTeacher
    {
        public int Id { get; set; }

        public int DeptId { get; set; }

        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public float CreditToBeTaken { get; set; }
        public float RemainingCredit { get; set; }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string Semester { get; set; }
        public float CourseCredit { get; set; }

    }
}
