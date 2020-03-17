using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class Master2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["ename"] == null)//checking cookie is created,if not goto login page
                Response.Redirect("Login.aspx");
            else
                Label1.Text = "welcome " + Request.Cookies["ename"].Value;
        }
    }
}