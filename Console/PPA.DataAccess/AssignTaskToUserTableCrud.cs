using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA.DataAccess
{
   public class AssignTaskToUserTableCrud
    {
        public void insertAssignTaskToUser()
        {
            // Create connection string and assing to class
            SqlConnection sqlconn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            sqlconn.Open();
            // Generate Query
            string query = "insert into ppa.AssignTaskToUserTable values(5,5,2,4,9,'must follow naming standards',GETDATE(),GETDATE())";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.ExecuteNonQuery();
            sqlconn.Close();
        }
    }
}
