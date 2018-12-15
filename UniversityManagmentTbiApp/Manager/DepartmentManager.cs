using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagmentTbiApp.Getway;
using UniversityManagmentTbiApp.Model;

namespace UniversityManagmentTbiApp.Manager
{
    class DepartmentManager
    {
        private DepartmentGetway departmentGetway;


        public DepartmentManager()
        {
            departmentGetway = new DepartmentGetway();
        }


        public string SaveDepartment(Department department)
        {


            int rowEffected = departmentGetway.SaveDepartment(department);

            if (rowEffected > 0)
            {
                return "Successfully saved";
            }

            else
            {
                return "Failed save";
            }


        }

        public List<Department> GetAllDepartments()
        {
            return departmentGetway.GetAllDepartment();
        }

        public bool IsExistCodeName(Department department)
        {

            return departmentGetway.IsExistCodeName(department);
        }


    }
}
