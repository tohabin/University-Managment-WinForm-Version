using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagmentTbiApp.Getway;
using UniversityManagmentTbiApp.Model;

namespace UniversityManagmentTbiApp.Manager
{
    class StudentManager
    {
        private StudentGetway studentGetway;
        
        public StudentManager()
        {
            studentGetway = new StudentGetway();
            
            
        }


        public string RegisterStudent(Student aStudent)
        {

            
            int rowEffected = studentGetway.RegisterStudent(aStudent);

            if (rowEffected > 0)
            {
                return "Successfully saved";
            }

            else
            {
                return "Failed save";
            }
            

        }
        public string DeleteStudent(Student aStudent)
        {

            int rowEffected = studentGetway.DeleteStudent(aStudent);

            if (rowEffected > 0)
            {
                return "successfully deleted";
            }

            else
            {
                return "Failed delete";
            }

        }

        public string EditStudent(Student student)
        {

            int rowEffected = studentGetway.EditStudent(student);

            if (rowEffected > 0)
            {
                return "Successfully Edited";
            }

            else
            {
                return "Failed Edit";
            }

        }



        public List<StudentWithDepartmentViewModel> GetAllStudents()
        {
            return studentGetway.GetAllStudents();
        }




        public bool IsExistEmail(Student aStudent)
        {
            return studentGetway.IsExistEmail(aStudent);

        }



        public string RegistraionNoGneraion(Student student)
        {
            // RegistraionNo = <Department>-<Year>-<SerialNo> 
            List<string> registraionNos = studentGetway.RegistraionNoGneraion(student);
            
            
            // get the serial no
            string serialNo;
            // if there is no registraion No at that department and at that year
            if (!registraionNos.Any())
            {
                serialNo = "000";
            }
            else
            {
                // Extract the last 3 substring and convert them to int And Make the list again in integer form
                List<int> serialNoOfRegistraionNo = new List<int>();
                foreach (var regNo in registraionNos)
                {
                    string serialNoStringFormate = regNo.Substring(regNo.Length - 3);
                    int serialNoIntFormate = int.Parse(serialNoStringFormate);

                    serialNoOfRegistraionNo.Add(serialNoIntFormate);
                }

                // get the max serial no and convert it into 000 3 digit format
                serialNo = (serialNoOfRegistraionNo.Max() + 1).ToString("000");



            }


            // get the department code
            DepartmentGetway departmentGetway = new DepartmentGetway();
            string code = departmentGetway.RegistraionNoGeneraion(student.DeptId);


            // get the year form date 
            string year = student.Date.Year.ToString();


            // Finally generate the registraion No
            return code + "-" + year + "-" + serialNo;


        }



    }
}
