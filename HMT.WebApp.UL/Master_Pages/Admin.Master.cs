using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMT.WebApp.UL.Master_Pages
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Guards against user created url.
            if (Session["firstName"].ToString() != "admin")
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void SignOut_Click(object sender, EventArgs e)
        {
            Session["greeting"] = "";
            Session["firstName"] = "";
            Session["password"] = "";
            Response.Redirect("Default.aspx");
        }
    }
}