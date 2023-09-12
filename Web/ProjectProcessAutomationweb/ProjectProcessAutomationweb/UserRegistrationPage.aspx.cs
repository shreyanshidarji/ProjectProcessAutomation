using PPA.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectProcessAutomationweb
{
    public partial class UserRegistrationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            UserCrud usercrud = new UserCrud();

            int userID =Convert.ToInt32(txtuserid.Text);
            string userName = txtusername.Text;
            string userPassword = txtuserpassword.Text;
            string userEmail = txtuseremail.Text;
            string userMobile = txtusermobile.Text;
            bool userActive = Convert.ToBoolean(txtuseractive.Text);
            int userSalary = Convert.ToInt32(txtusersalary);

           usercrud.registerUser(userID, userName, userPassword, userEmail, userMobile, userActive, userSalary);



            Response.Redirect("UserDashboardPage.aspx");
        }
    }
}