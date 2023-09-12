using PPA.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectProcessAutomationweb
{
    public partial class UserDashboardPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserCrud userCrud = new UserCrud();
            userCrud.GetData();
           
            Repeater1.DataSource = userCrud.GetData();
            Repeater1.DataBind();
            
            GridView1.DataSource= userCrud.GetData();
            GridView1.DataBind();

        }

        
    }
}