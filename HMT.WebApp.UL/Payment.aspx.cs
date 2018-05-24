using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMT.WebApp.UL
{
    public partial class Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Session["total"] = 0;
            Session["cart"] = "";
            Session["name"] = "Your Cart is empty";
            Session["price"] = "";
            Session["image"] = "Images/emptycart.png";
            Response.Redirect("Default.aspx");
        }
    }
}