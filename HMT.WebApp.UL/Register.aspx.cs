using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMT.WebApp.UL
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["firstName"].ToString() != "" && Session["firstName"].ToString() != "-1")
            {
                Session["greeting"] = "Already Signed In";
                Response.Redirect("Default.aspx");
            }
        }

        protected void register_Click(object sender, EventArgs e)
        {
            Session["firstName"] = fname.Text;
            Session["lastName"] = lname.Text;
            Session["email"] = txtEmail.Text;
            Session["password"] = pass1.Text;
            Session["address"] = address.Text;

            Response.Redirect("Sign_In.aspx");
            
        }
    }
}