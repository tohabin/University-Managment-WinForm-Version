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
    class CourseGetway
    {
        private string conString = ConfigurationManager.ConnectionStrings["UniversityManagment"].ConnectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public CourseGetway()
        {
            connection = new SqlConnection(conString);
        }

        public int SaveCourse(Course course)
        {

            string query = "INSERT INTO COURSE (Code,Name,Credit,Description,DeptId,Semester) VALUES('"+course.Code+"','"+course.Name+"',"+course.Credit+",'"+course.Description+"',"+course.DeptId+",'"+course.Semester+"')";

            connection.Open();
            command = new SqlCommand(query, connection);
            int roweffected = command.ExecuteNonQuery();

            connection.Close();
            return roweffected;
        }

        public List<Course> GetAllCourse(int deptId)
        {
            string query = "SELECT * FROM Course WHERE deptId = "+deptId+"";

            connection.Open();

            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            List<Course> courses = new List<Course>();

            while (reader.Read())
            {
                Course aCourse = new Course()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Code = reader["Code"].ToString(),
                    Name = reader["Name"].ToString(),
                    Credit = float.Parse(reader["credit"].ToString())

                };

                courses.Add(aCourse);

            }


            connection.Close();
            return courses;
        }


        public Course GetACourse(int courseId)
        {
            string query = "SELECT * FROM Course WHERE Id=" + courseId + "";

            connection.Open();
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            Course course = new Course();
            while (reader.Read())
            {
                course.Name = reader["Name"].ToString();
                course.Credit = float.Parse(reader["Credit"].ToString());

            }
            reader.Close();
            connection.Close();
            return course;
        }

    }
}
