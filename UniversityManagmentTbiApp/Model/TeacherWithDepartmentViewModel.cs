using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagmentTbiApp.Model
{
    class TeacherWithDepartmentViewModel 
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public String Address { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public int DeptId { get; set; }
        public string Designation { get; set; }
        public float CreditToBeTaken { get; set; }
        public string Code { get; set; }
        public string DeptName { get; set; }
    }
}
