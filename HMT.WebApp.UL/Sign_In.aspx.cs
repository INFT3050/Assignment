using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMT.WebApp.UL
{
    public partial class Sign_In : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.ToLower() == "bob" && pass1.Text == "password")
            {
                Session["greeting"] = "Welcome Back " + txtEmail.Text + "!";
                Session["firstName"] = txtEmail.Text;
                Session["password"] = pass1.Text;
                Response.Redirect("Default.aspx");
            }

            if(txtEmail.Text.ToLower() == "admin" && pass1.Text == "admin")
            {
                Session["greeting"] = "Welcome Back " + txtEmail.Text + "!";
                Session["firstName"] = txtEmail.Text;
                Session["password"] = pass1.Text;
                Response.Redirect("Admin_Home.aspx");
            }

            if (txtEmail.Text.ToLower() == Session["email"].ToString().ToLower() && pass1.Text == Session["password"].ToString())
            {
                Session["greeting"] = "Welcome Back " + Session["firstName"].ToString() + " " + Session["lastName"].ToString() + "!";
                Response.Redirect("Default.aspx");
            }
        }
    }
}