using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagmentTbiApp.Model
{
    class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public int DeptId { get; set; }
        public string Designation { get; set; }
        public float CreditToBeTaken { get; set; }
        public float RemainingCredit { get; set; }
    }
}
