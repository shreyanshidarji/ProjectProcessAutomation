using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA.DataAccess
{
    public class CompletedTaskTableCrud
    {
        public void insertCompletedTask()
        {
            // Create connection string and assing to class
            SqlConnection sqlconn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            sqlconn.Open();
            // Generate Query
            string query = "insert into ppa.CompletedTaskTable values(6,1,1,1,'completed task',GETDATE(),GETDATE())";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.ExecuteNonQuery();
            sqlconn.Close();
        }
       /* public void deleteCompletedTask()
        {
            // Create connection string and assing to class
            SqlConnection sqlconn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            sqlconn.Open();
            // Generate Query
            string query = "delete * from ppa.CompletedTaskTable where completedTaskId=6";
            SqlCommand cmd = new SqlCommand(query,sqlconn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.ExecuteNonQuery();
            sqlconn.Close();
        }*/
    }
}
