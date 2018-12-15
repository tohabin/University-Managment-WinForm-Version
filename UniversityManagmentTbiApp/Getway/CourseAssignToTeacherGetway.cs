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
    class CourseAssignToTeacherGetway
    {
        private string conString = ConfigurationManager.ConnectionStrings["UniversityManagment"].ConnectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public CourseAssignToTeacherGetway()
        {
            connection = new SqlConnection(conString);
        }


        public int SaveCourseAssignToTeacher(CourseAssignToTeacher courseAssignToTeacher)
        {
            string query1 = "INSERT INTO CourseAssignToTeacher(TeacherId,CourseId,DeptId)  VALUES(" + courseAssignToTeacher.TeacherId + ", " + courseAssignToTeacher.CourseId + ", " + courseAssignToTeacher.DeptId + ")";
            string query2 = "UPDATE Teacher SET RemainingCredit = "+courseAssignToTeacher.RemainingCredit+" WHERE Id = "+courseAssignToTeacher.TeacherId+"";

            connection.Open();

            command = new SqlCommand(query1, connection);
            int rowEffected = command.ExecuteNonQuery();
            command = new SqlCommand(query2, connection);
            command.ExecuteNonQuery();
            connection.Close();

            return rowEffected;

        }


        public int UnassignTeacherFromCourse()
        {
            string query1 = "DELETE FROM	CourseAssignToTeacher";
            string query2 = "UPDATE Teacher SET RemainingCredit = CreditToBeTaken";

            connection.Open();

            command = new SqlCommand(query1, connection);
            int rowEffected = command.ExecuteNonQuery();
            command = new SqlCommand(query2, connection);
            command.ExecuteNonQuery();
            connection.Close();

            return rowEffected;

        }

        public bool IsExistCourse(CourseAssignToTeacher courseAssignToTeacher)
        {

            string query = "SELECT * FROM CourseAssignToTeacher WHERE CourseId = " + courseAssignToTeacher.CourseId + "";

            connection.Open();

            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            bool isEixst = reader.HasRows;

            connection.Close();
            return isEixst;

        }


        public List<CourseAssignToTeacher> GetAllCourseAssignToTeachers(int deptId)
        {
            string query = "SELECT * FROM CourseAssignToTeacherView WHERE deptId = " + deptId + "";

            connection.Open();

            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            List<CourseAssignToTeacher> courses = new List<CourseAssignToTeacher>();

            while (reader.Read())
            {
                CourseAssignToTeacher aCourse = new CourseAssignToTeacher();

                aCourse.CourseCode = reader["Code"].ToString();
                aCourse.CourseName = reader["CourseName"].ToString();
                aCourse.Semester = reader["Semester"].ToString();
                aCourse.TeacherName = reader["TeacherName"].ToString();



                courses.Add(aCourse);

            }


            connection.Close();
            return courses;
        }


    }
}
