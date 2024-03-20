using System;
using System.Web.UI;

namespace KitchenStory
{
    public partial class AdminLogin : Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Add authentication logic here
            if (username == "admin" && password == "adminpassword")
            {
                // Redirect to AdminDashboard.aspx upon successful login
                Response.Redirect("AdminDashboard.aspx");
            }
            else
            {
                // Display error message
                Response.Write("<script>alert('Invalid username or password.')</script>");
            }
        }
    }
}
