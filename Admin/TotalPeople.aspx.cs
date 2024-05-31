using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewLifeKtm.Admin
{
    public partial class TotalPeople : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                if (!IsPostBack)
                {
                    GridViewDataBind();
                    CheckService();
                }
            }
            else
            {
                Response.Redirect("AdminLogin.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if(con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "INSERT INTO tblTotalPeople(Date, Service, Preacher, Total_People, New_People, Done_by)VALUES(@Date, @Service, @Preacher, @Total_People, @New_People, @Done_by)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Date", txtDate.Text.Trim());
                cmd.Parameters.AddWithValue("@Service", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@Preacher", txtPreacher.Text.Trim());
                cmd.Parameters.AddWithValue("@Total_People", txtTotal.Text.Trim());
                cmd.Parameters.AddWithValue("@New_People", txtNew.Text.Trim());
                cmd.Parameters.AddWithValue("@Done_by", txtDone.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('Successfully Added')</script>");

                txtDate.Text = string.Empty;
                txtPreacher.Text = string.Empty;
                txtTotal.Text = string.Empty;
                txtNew.Text = string.Empty;
                txtDone.Text = string.Empty;
                DropDownList1.SelectedItem.Value = string.Empty;

                GridViewDataBind();
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('"+ex.Message+"')</script>");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "DELETE FROM tblTotalPeople WHERE Date = '"+txtDate.Text.Trim()+"' AND Service = '"+ DropDownList1.SelectedItem.Value + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        Response.Write("<script>alert('Deleted Succesfully')</script>");
                    }
                    txtDate.Text = string.Empty;
                }
                else
                {
                    Response.Write("<script>alert('No data found')</script>");
                    txtDate.Text = string.Empty;
                }

                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }

        void GridViewDataBind()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblTotalPeople", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                else
                {
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
        void CheckService()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT Name FROM tblService", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DropDownList1.DataSource = dt;
                DropDownList1.DataValueField = "Name";
                DropDownList1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
    }
}