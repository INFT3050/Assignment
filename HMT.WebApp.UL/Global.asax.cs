﻿using System;
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
            Session["cart"] = "";
            Session["name"] = "Your Cart is empty";
            Session["price"] = 0;
            Session["image"] = "Images/emptycart.png";
            Session["Total"] = 0;
            Session["firstName"] = "-1";
            Session["lastName"] = "";
            Session["email"] = "";
            Session["password"] = "";
            Session["address"] = "";
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