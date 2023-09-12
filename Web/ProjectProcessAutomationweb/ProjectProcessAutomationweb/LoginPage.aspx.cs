using PPA.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectProcessAutomationweb
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       


        protected void btnlogin_Click1(object sender, EventArgs e)
        {



             UserCrud usercrud = new UserCrud();


             string userEmail = txtuseremail.Text; 
             string userPassword = txtuserpassword.Text;


             bool loggedIn = usercrud.loginUser(userEmail, userPassword, out string validationmessage);

             if (loggedIn)
             {
                Session["useremail"] = userEmail;
                 lblloginsuccess.Text = "Login Success";
                Response.Redirect("UserDashboardPage.aspx");
                
             }
             else
             {
                 lblloginsuccess.Text = validationmessage;
             }
           
        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            txtuseremail.Text = " ";
            txtuserpassword.Text = " ";

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        protected void btnsignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserRegistrationPage.aspx");
        }
    }
}