using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewLifeKtm.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null)
                {
                    LinkLogin.Visible = true;
                    LinkButton1.Visible = false;
                    LinkHello.Visible = false;
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkLogin.Visible = false;
                    LinkButton1.Visible = true;
                    LinkHello.Visible = true;
                    LinkHello.Text = "Hello " + Session["username"].ToString();
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["role"] = "";

            LinkLogin.Visible = true;
            LinkButton1.Visible = false;
            LinkHello.Visible = false;

            Response.Redirect("AdminLogin.aspx");
        }

        protected void LinkLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }
    }
}