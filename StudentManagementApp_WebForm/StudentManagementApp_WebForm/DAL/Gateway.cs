using System.Data.SqlClient;
using System.Web.Configuration;

namespace StudentManagementApp_WebForm.DAL
{
   

    public class Gateway
    {
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
      
        public Gateway(string connectionName)
        {
            Connection = new SqlConnection(WebConfigurationManager.ConnectionStrings[connectionName].ConnectionString);
            Command = new SqlCommand();
            Command.Connection = Connection;
        }
        

        
    }
}