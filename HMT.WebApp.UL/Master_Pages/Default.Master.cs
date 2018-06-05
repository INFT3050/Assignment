using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMT.WebApp.UL.Master_Pages
{
    public partial class Default : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["firstName"].ToString() != "" && Session["firstName"].ToString() != "-1")
            {
                signInOut.Text = "Sign Out";
            }
            else
            {
                signInOut.Text = "Sign In";
            }

            if (Session["LoggedIn"].ToString() == "1")
                greeting.Text = "Welcome Back!";
        }

        protected void LogInOut(object sender, EventArgs e)
        {
            if (Session["LoggedIn"].ToString() == "1")
            {
                //Signed in already. Therefore sign out.
                Session["greeting"] = "Successfully Signed Out";
                Session["firstName"] = "";
                Session["password"] = "";
                Session["LoggedIn"] = "0";
                Response.Redirect("Default.aspx");
            }
            else
            {
                Session["greeting"] = "";
                Response.Redirect("Sign_In.aspx");
            }
        }

        protected void MenClick(object sender, EventArgs e)
        {
            Session["search"] = "Gender = 'M'";
            Session["description"] = "Men's Clothing";
            Response.Redirect("Search.aspx");
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTxt.Text == "")
            { }
            else
            {
                Session["search"] = "ProductNAME LIKE '" + searchTxt.Text + "%'";
                Session["description"] = searchTxt.Text;
                Response.Redirect("Search.aspx");
            }
        }
    }
}