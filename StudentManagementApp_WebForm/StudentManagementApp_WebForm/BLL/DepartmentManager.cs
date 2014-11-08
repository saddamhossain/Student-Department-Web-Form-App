using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentManagementApp_WebForm.DAL;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway aDepartmentGateway = new DepartmentGateway();
        public DepartmentManager()
        {
           aDepartmentGateway = new DepartmentGateway();
        }

        public  bool Insert(Department aDepartment)
        {
            int rowAffected = 0;
            if (!IsCodeExist(aDepartment))
            {
                rowAffected = aDepartmentGateway.Insert(aDepartment);
            }         

            return rowAffected > 0;
        }

        private bool IsCodeExist(Department aDepartment)
        {
            Department retrivedStudent = aDepartmentGateway.GetStudentByCode(aDepartment.Code);

            return retrivedStudent != null;
        }

        public List<Department> GetAllDepartment()
        {
            return aDepartmentGateway.GetAllDepartment();
        }
     
    }
}