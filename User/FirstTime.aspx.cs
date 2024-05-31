using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewLifeKtm.User
{
    public partial class FirstTime : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Submit Button
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "INSERT INTO tblFirstTimeGuest(Date, Name, Email, Number, Address) VALUES(@Date, @Name, @Email, @Number, @Address)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Date", txtDate.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Number", txtNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('Thankyou for filling the form')</script>");
                ClearForm();
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
        void ClearForm()
        {
            txtDate.Text = string.Empty;
            txtName.Text = string.Empty;    
            txtEmail.Text = string.Empty;
            txtNumber.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }
    }
}