using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from ASPEmp where Empid=@Eid and password=@p",con);
            adp.SelectCommand.Parameters.AddWithValue("@Eid",int.Parse(txtempid.Text));
            adp.SelectCommand.Parameters.AddWithValue("@p", txtpwd.Text);
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            if (ds.Tables["E"].Rows.Count == 1)
            {
                string name = ds.Tables["E"].Rows[0][1].ToString();
                string type = ds.Tables["E"].Rows[0][3].ToString();
                if (type == "Admin")
                {
                    Response.Cookies["ename"].Value = name;
                    Response.Redirect("Admin.aspx");
                }
                else if (type == "Associate")
                {
                    Response.Cookies["ename"].Value = name;
                    Response.Redirect("Associate.aspx");
                }
            }
            else
                lblmsg.Text = "Invalid credentials";
        }
    }
}