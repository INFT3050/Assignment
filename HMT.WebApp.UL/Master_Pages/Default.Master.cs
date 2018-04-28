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
        }

        protected void LogInOut(object sender, EventArgs e)
        {
            if (Session["firstName"].ToString() != "" && Session["firstName"].ToString() != "-1")
            {
                //Signed in already. Therefore sign out.
                Session["greeting"] = "Successfully Signed Out";
                Session["firstName"] = "";
                Session["password"] = "";
                Response.Redirect("Default.aspx");
            }
            else
            {
                Session["greeting"] = "";
                Response.Redirect("Sign_In.aspx");
            }
        }
    }
}