using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EC1_Lab2
{
    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            lblRegisteredUsers.Text = "Registered Users: "+ Application["userCount"].ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Session["FirstName"] = txtFirstName.Text; //set firstname session variable
            Session["LastName"] = txtLastName.Text; //set lastname session variable

            int uCount = (int)Application["userCount"];
            uCount++;
            Application["userCount"] = uCount;


            Response.Redirect("~/Welcome.aspx"); //go to welcome page
        }
    }
}