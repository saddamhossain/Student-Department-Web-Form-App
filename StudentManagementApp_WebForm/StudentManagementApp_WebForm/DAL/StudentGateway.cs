using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.DAL
{
    public class StudentGateway:Gateway
    {

        public StudentGateway():base("StudentConnectionString")
        {

          
        }

        public Student GetStudentByRegNo(string regNo)
        {
            Student student = null;
            var query = "SELECT * FROM Student WHERE RegNo = '" + regNo + "'";

            Command.CommandText = query;
            
            Connection.Open();
            SqlDataReader rdr = Command.ExecuteReader();

            while (rdr.Read())
            {
                student = new Student();
                student.RegNo = rdr["RegNo"].ToString();
                student.Name = rdr["Name"].ToString();
                student.Email = rdr["Email"].ToString();
                student.ID = Convert.ToInt32(rdr["ID"]);
                student.DeptID = (int) rdr["DeptID"];
            }

            rdr.Close();
            Connection.Close();
            return student;
        }

        public int Insert(Student student)
        {
            var query = @"INSERT INTO Student VALUES('" + student.RegNo + "','" + student.Name + "','" + student.Email +
                        "','" + student.DeptID + "')";

            Command.CommandText = query;

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

        public List<Student> GetAllStudent()
        {
            List<Student> students = new List<Student>();

            var query = "SELECT * FROM Student";

            Command.CommandText = query;

            Connection.Open();
            SqlDataReader rdr = Command.ExecuteReader();

            while (rdr.Read())
            {
                var student = new Student();
                student = new Student();
                student.RegNo = rdr["RegNo"].ToString();
                student.Name = rdr["Name"].ToString();
                student.Email = rdr["Email"].ToString();
                student.ID = Convert.ToInt32(rdr["ID"]);
                student.DeptID = (int) rdr["DeptID"];
                students.Add(student);
            }

            rdr.Close();
            Connection.Close();

            return students;
        }
    }
}