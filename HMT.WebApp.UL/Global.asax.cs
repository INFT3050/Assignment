using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace HMT.WebApp.UL
{
    public class Global : System.Web.HttpApplication
    {
        //static string 


        protected void Application_Start(object sender, EventArgs e)
        {
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // Code run when session begins
            Session["LoggedIn"] = "0";
            Session["name"] = "Your Cart is empty";
            Session["image"] = "Images/emptycart.png";
            Session["Total"] = 0;
            Session["ID"] = 0;
            Session["firstName"] = "-1";
            Session["lastName"] = "";
            Session["email"] = "";
            Session["password"] = "";
            Session["address"] = "";
            Session["ResetEmail"] = "";
            Session["search"] = "";
            Session["description"] = "Men's Clothing";
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}