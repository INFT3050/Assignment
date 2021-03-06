﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HMT.WebApp.BLL.App_Code;
using HMT.WebApp.DAL.App_Code;

namespace HMT.WebApp.UL
{
    public partial class Sign_In : System.Web.UI.Page
    {
        BuisnessLayer cust = new BuisnessLayer();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.pass1.Attributes.Add("onkeypress", "button_click(tihs, '" + this.pass1.ClientID + "')");
        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            int check = cust.CheckLogin(txtEmail.Text, pass1.Text);

            if (check == 0)
                errorMsg.Text = "Incorrect email or password";
            else if (check == 1)
                errorMsg.Text = "Incorrect password";
            else if (check == 2)
            {
                Customer temp = cust.getCustomer(txtEmail.Text);
                Session["ID"] = temp.id;
                Session["firstName"] = temp.firstName;
                Session["lastName"] = temp.lastName;
                Session["email"] = txtEmail.Text;
                Session["address"] = temp.address;
                Session["password"] = pass1.Text;

                Session["LoggedIn"] = "1";
                Response.Redirect("Default.aspx");
            }
            else if (check == 3)
            {
                errorMsg.Text = "This account has been suspended";
            }

            else if (check == 4)
            {
                Session["firstName"] = "admin";
                Response.Redirect("Admin_Home.aspx");

            }
        }
    }
}