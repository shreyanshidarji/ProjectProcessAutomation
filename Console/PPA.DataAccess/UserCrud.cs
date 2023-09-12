using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Web;

namespace PPA.DataAccess
{
    public class UserCrud
    {
        private readonly SqlConnection sqlconn;

        public UserCrud()
        {
           sqlconn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
        }


        public DataTable GetData()
        {
          //  SqlConnection sqlconn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            sqlconn.Open();
            string query = "select userId,userName from ppa.UserTable ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlconn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        
        public void insertUser()
        {
            // Create connection string and assing to class
          //  SqlConnection sqlconn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            sqlconn.Open();
            // Generate Query
            string query = "insert into ppa.UserTable values (7,'rajesh','rjs123','rjs@yahoo.com','9495936250',0,40000,GETDATE(),GETDATE())";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.ExecuteNonQuery();
            sqlconn.Close();
        }

        public void registerUser(int userId,string userName,string userPassword,string userEmail,string userMobile,bool userActive,int userSalary)
        {
           // SqlConnection sqlconn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            sqlconn.Open();

            string query = "insert into ppa.UserTable values (@userId,@userName,@userPassword,@userEmail,@userMobile,@userActive,@userSalary)";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@userPassword", userPassword);
            cmd.Parameters.AddWithValue("@userEmail", userEmail);
            cmd.Parameters.AddWithValue("@userMobile", userMobile);
            cmd.Parameters.AddWithValue("@userActive", userActive);
            cmd.Parameters.AddWithValue("@userSalary", userSalary);
            
            cmd.ExecuteNonQuery();
            sqlconn.Close();
        }
        public bool loginUser(string userEmail, string userPassword, out string validationmessage)
        {

            //SqlConnection sqlconn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            sqlconn.Open();

            string query = "SELECT count(*) FROM ppa.UserTable where userEmail =@userEmail ";
            SqlCommand command = new SqlCommand(query, sqlconn);


            command.Parameters.AddWithValue("@userEmail", userEmail);
            command.Parameters.AddWithValue("@userPassword", userPassword);

            int userCount = (int)command.ExecuteScalar();
            sqlconn.Close();
           
            if (userCount == 0)
            {
                validationmessage = "useremail not exists";
                return false;
            }




            string quer = "SELECT count(*) FROM ppa.UserTable where userEmail =@userEmail AND userPassword =@userPassword";
            command = new SqlCommand(quer, sqlconn);

            command.Parameters.AddWithValue("@userEmail", userEmail);
            command.Parameters.AddWithValue("@userPassword", userPassword);

            sqlconn.Open();
            userCount = (int)command.ExecuteScalar();
            sqlconn.Close();

            validationmessage = userCount == 0 ? "credentials not matched" : string.Empty;
            return userCount > 0;

        }
    }

}

    






























    
      
     

