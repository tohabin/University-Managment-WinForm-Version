using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagmentTbiApp.Model
{
    class StudentWithDepartmentViewModel
    {
        public int StudentId { get; set; }
        public string RegistraionNo { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public string Code { get; set; }
        public string DepartmentName { get; set; }
    
    }
}
