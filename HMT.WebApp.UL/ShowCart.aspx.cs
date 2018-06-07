using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMT.WebApp.UL
{
    public partial class ShowCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rmvFromCart_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Session["total"]) != 0)
                {
                    double x = Convert.ToDouble(Session["total"]);
                    double y = Convert.ToDouble(Session["price"]);
                    Session["total"] = x - y;
                }
            
            Session["cart"] = "";
            Session["name"] = "Your Cart is empty";
            Session["price"] = "";
            Session["image"] = "Images/emptycart.png";
            Response.Redirect("Cart.aspx");
        }
    }
}