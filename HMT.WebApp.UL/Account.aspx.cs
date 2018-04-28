using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMT.WebApp.UL
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Source account details from database and update asp labels
            if(Session["firstName"].ToString() == "-1" || Session["firstName"].ToString() == "")
                Response.Redirect("Sign_In.aspx");
            else
            {
                firstName.Text = Session["firstName"].ToString();
                lName.Text = Session["lastName"].ToString();
                eMail.Text = Session["email"].ToString();
                password.Text = Session["password"].ToString();
                address.Text = Session["address"].ToString();
            }
        }

        protected void updateChanges_Click(object sender, EventArgs e)
        {
            Session["firstName"] = firstName.Text;
            Session["lastName"] = lName.Text;
            Session["email"] = eMail.Text;
            Session["password"] = password.Text;
            Session["address"] = address.Text;
            Response.Redirect("Account.aspx");
        }
    }
}