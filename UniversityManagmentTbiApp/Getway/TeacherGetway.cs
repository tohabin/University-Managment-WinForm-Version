using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagmentTbiApp.Model;

namespace UniversityManagmentTbiApp.Getway
{
    class TeacherGetway
    {
        private string conString = ConfigurationManager.ConnectionStrings["UniversityManagment"].ConnectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public TeacherGetway()
        {
            connection = new SqlConnection(conString);
        }


        public int SaveTeacherForm(Teacher teacher)
        {
            string query = "INSERT INTO  Teacher (Name,Address,Email,Contact,DeptId,Designation,CreditToBeTaken,RemainingCredit) VALUES('"+teacher.Name+"','"+teacher.Address+"','"+teacher.Email+"','"+teacher.Contact+"',"+teacher.DeptId+",'"+teacher.Designation+"',"+teacher.CreditToBeTaken+",'"+teacher.CreditToBeTaken+"')";

            connection.Open();

            command = new SqlCommand(query, connection);
            int rowEffected = command.ExecuteNonQuery();

            connection.Close();

            return rowEffected;

        }

        public List<TeacherWithDepartmentViewModel> GetAllTeacherWithDepartment(int deptId)
        {
            string query;
            if(deptId == -1)
                query = "SELECT * FROM TeacherWithDepartmentView ORDER BY DeptId";

            else
                query = "SELECT * FROM TeacherWithDepartmentView WHERE DeptId = "+deptId+"";

            connection.Open();
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            List<TeacherWithDepartmentViewModel> teachers = new List<TeacherWithDepartmentViewModel>();
            while (reader.Read())
            {
                TeacherWithDepartmentViewModel teacher = new TeacherWithDepartmentViewModel();

                teacher.TeacherId = Convert.ToInt32(reader["TeacherId"]);
                teacher.TeacherName = reader["TeacherName"].ToString();
                teacher.Address = reader["Address"].ToString();
                teacher.Email = reader["Email"].ToString();
                teacher.Contact = reader["Contact"].ToString();
                teacher.DeptId = Convert.ToInt32(reader["DeptId"]);
                teacher.Designation = reader["Designation"].ToString();
                
                float f;
                float.TryParse(reader["CreditToBeTaken"].ToString(),out f);
                teacher.CreditToBeTaken = f;
                
                teacher.Code = reader["Code"].ToString();
                teacher.DeptName = reader["DeptName"].ToString();
                
                teachers.Add(teacher);
            }

            
            connection.Close();
            return teachers;
        }

        public Teacher GetATeacher(int TeacherId)
        {
            string query = "SELECT * FROM Teacher WHERE Id=" + TeacherId + "";

            connection.Open();
            command = new SqlCommand(query,connection);
            reader = command.ExecuteReader();
            Teacher teacher = new Teacher();
            while (reader.Read())
            {
                teacher.CreditToBeTaken = float.Parse(reader["CreditToBeTaken"].ToString());
                teacher.RemainingCredit = float.Parse(reader["RemainingCredit"].ToString());

            }
            reader.Close();
            connection.Close();
            return teacher;
        }

    }
}
