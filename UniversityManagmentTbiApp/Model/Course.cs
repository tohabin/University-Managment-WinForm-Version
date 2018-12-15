using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagmentTbiApp.Model
{
    class Course
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public float Credit { get; set; }
        public string Description { get; set; }
        public int DeptId { get; set; }
        public string Semester { get; set; }
    }
}
