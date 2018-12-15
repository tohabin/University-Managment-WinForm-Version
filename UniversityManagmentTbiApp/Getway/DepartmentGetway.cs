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
    class DepartmentGetway
    {
        private string conString = ConfigurationManager.ConnectionStrings["UniversityManagment"].ConnectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public DepartmentGetway()
        {
            connection = new SqlConnection(conString);
        }

        public int SaveDepartment(Department department)
        {

            string query = "INSERT INTO Department VALUES('"+department.Code+"','"+department.Name+"')";

            connection.Open();

            command = new SqlCommand(query, connection);
            int rowEffected = command.ExecuteNonQuery();

            connection.Close();

            return rowEffected;

        }


        
        
        public List<Department> GetAllDepartment()
        {
            string query = "SELECT * FROM Department";

            connection.Open();

            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            List<Department> departments = new List<Department>();

            while (reader.Read())
            {
                Department aDepartment = new Department
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Code = reader["Code"].ToString(),
                    Name = reader["Name"].ToString()
                 
                };

                departments.Add(aDepartment);

            }


            connection.Close();
            return departments;
        }


        public bool IsExistCodeName(Department department)
        {
            string query = "SELECT * FROM Department WHERE (Code = '"+department.Code+"'OR Name = '"+department.Name+"') AND (Id <> "+department.Id+")";

            connection.Open();

            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            bool isEixst = reader.HasRows;

            connection.Close();
            return isEixst;

        }


        public string RegistraionNoGeneraion(int departmentId)
        {
            //find the department code for a specific department ID

            string query = "SELECT code FROM Department"+
                            " WHERE Id = "+departmentId+"";

            connection.Open();

            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();


            string code = "";
            while (reader.Read())
            {
                
                code = reader["Code"].ToString();
                
            }
            
            connection.Close();
            return code;


        }
        





    }



}
