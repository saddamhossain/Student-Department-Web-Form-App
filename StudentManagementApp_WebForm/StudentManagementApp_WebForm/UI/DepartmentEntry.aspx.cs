using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentManagementApp_WebForm.BLL;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.UI
{
    public partial class DepartmentEntry : System.Web.UI.Page
    {

        DepartmentManager aDepartmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            msgLabel.Text = "";
        }

        protected void deptSave_OnClick(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var code = txtcode.Text;


            Department aDepartment = new Department(code, name);

            bool isSaved = aDepartmentManager.Insert(aDepartment);

            if (isSaved)
            {
                msgLabel.Text = "Saved Successfully!";
            }
            else
            {
                msgLabel.Text = "Insertion Failed!";
            }
        }
    }
}