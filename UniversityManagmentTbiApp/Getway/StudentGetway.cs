using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagmentTbiApp.Model;

namespace UniversityManagmentTbiApp.Getway
{
    class StudentGetway
    {

        private string conString = ConfigurationManager.ConnectionStrings["UniversityManagment"].ConnectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public StudentGetway()
        {
            connection = new SqlConnection(conString);
        }

        public int RegisterStudent(Student aStudent)
        {

            string query = "INSERT INTO Student  VALUES('" + aStudent.Name + "','" + aStudent.Email + "','" + aStudent.ContactNo + "','" + aStudent.Date.ToString("yyyy-MM-dd") + "','" + aStudent.Address + "','" + aStudent.DeptId + "', '" + aStudent.RegistraionNo + "')";

            connection.Open();

            command = new SqlCommand(query, connection);
            int rowEffected = command.ExecuteNonQuery();

            connection.Close();

            return rowEffected;

        }

        public int DeleteStudent(Student student)
        {
            string query = "DELETE FROM Student WHERE Id = " + student.Id + "";

            connection.Open();

            command = new SqlCommand(query, connection);
            int rowEffected = command.ExecuteNonQuery();

            connection.Close();

            return rowEffected;
        }

        public int EditStudent(Student student)
        {
            string query = "UPDATE Student " +
            "SET Name = '" + student.Name + "', Email  = '" + student.Email + "', ContactNo = '" + student.ContactNo + "', Date = '" + student.Date.ToString("yyyy-MM-dd") + "', Address = '" + student.Address + "', DeptId = " + student.DeptId + " " +
            "WHERE Id = " + student.Id + " ";

            connection.Open();

            command = new SqlCommand(query, connection);
            int rowEffected = command.ExecuteNonQuery();

            connection.Close();

            return rowEffected;


        }






        public List<StudentWithDepartmentViewModel> GetAllStudents()
        {
            string query = "SELECT * FROM StudentWithDepartmentViewModel"+
                " ORDER BY DepartmentId, Date";

            connection.Open();

            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            List<StudentWithDepartmentViewModel> students = new List<StudentWithDepartmentViewModel>();
            while (reader.Read())
            {
                StudentWithDepartmentViewModel aStudent = new StudentWithDepartmentViewModel
                {
                    StudentId = Convert.ToInt32(reader["StudentId"]),
                    RegistraionNo = reader["RegistraionNo"].ToString(),
                    StudentName = reader["StudentName"].ToString(),
                    Email = reader["Email"].ToString(),
                    ContactNo = reader["ContactNo"].ToString(),
                    Date = DateTime.Parse(reader["Date"].ToString()),
                    Address = reader["Address"].ToString(),
                    DepartmentId = Convert.ToInt32(reader["DepartmentId"]),
                    Code = reader["Code"].ToString(),
                    DepartmentName = reader["DepartmentName"].ToString()
                };
                students.Add(aStudent);
            }
            connection.Close();
            return students;
        }




        public bool IsExistEmail(Student student)
        {

            string query = "SELECT * FROM Student WHERE Email = '"+student.Email+"' AND id <>"+student.Id+"  ";

            connection.Open();

            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            bool isEixst = reader.HasRows;
            
            connection.Close();
            return isEixst;
        }

        public List<string> RegistraionNoGneraion(Student student)
        {
            //get all student's RegistraionNo of a department 

            string query = "SELECT * FROM Student AS s WHERE YEAR(s.Date) = "+student.Date.Year.ToString()+" AND s.DeptId = "+student.DeptId;

            connection.Open();

            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            List<string> registraionNos = new List<string>();
            while (reader.Read())
            {
                string aRegistraionNo = reader["RegistraionNo"].ToString();
                registraionNos.Add(aRegistraionNo);
            }
            connection.Close();
            return registraionNos;
        }




    }
}
