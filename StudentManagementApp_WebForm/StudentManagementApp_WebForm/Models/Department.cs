using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApp_WebForm.Models
{
    public class Department
    {
        public int DeptId { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }

        public Department(string code, string name):this()
        {
            Code = code;
            Name = name;
        }

        public Department()
        {
        }
    }
}