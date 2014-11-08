using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using StudentManagementApp_WebForm.DAL;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.BLL
{
    
    public class StudentManager
    {
        public StudentManager()
        {
            studentGateway = new StudentGateway();
        }

        StudentGateway studentGateway = new StudentGateway();
        public bool Insert(Student student)
        {
            int rowAffected = 0;
            if (!IsRegNoExist(student))
            {
                rowAffected =  studentGateway.Insert(student);
            }
            else
            {
                throw new Exception("Reg No already exists!");
            }

            if (rowAffected > 0)
                return true;
            return false;

        }

        private bool IsRegNoExist(Student student)
        {
            Student retrivedStudent = studentGateway.GetStudentByRegNo(student.RegNo);

            return retrivedStudent!=null;
        }

        public List<Student> GetAllStudent()
        {
            return studentGateway.GetAllStudent();
        }

        public Student GetStudentByRegNo(string regNo)
        {
            return studentGateway.GetStudentByRegNo(regNo);
        }
    }
}