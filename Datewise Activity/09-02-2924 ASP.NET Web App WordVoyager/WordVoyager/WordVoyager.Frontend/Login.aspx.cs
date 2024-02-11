using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WordVoyager.Frontend
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

            private bool IsValidCredentials(string email, string password)
        {
            // You would typically validate the credentials against a database
            // For demonstration purposes, let's assume a simple check
            return email == "lotushotmail111@gmail.com" && password == "123";
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string email = Request.Form["emailAdderss"]; // Retrieve email from form
            string password = Request.Form["password"]; // Retrieve password from form
            if (IsValidCredentials(email, password))
            {
                // Redirect the user to the home page
                Response.Redirect("Register.aspx");
            }
            else
            {
                
            }
        }
    }
}