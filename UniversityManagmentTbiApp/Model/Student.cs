using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagmentTbiApp.Model
{
    class Student
    {
        public int Id { get; set; }
        public string RegistraionNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public int DeptId { get; set; }
    }
}
