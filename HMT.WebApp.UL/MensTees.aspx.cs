using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMT.WebApp.UL
{
    public partial class MensTees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddProduct1(object sender, EventArgs e)
        {
            Session["name"] = "Men's Green Striped Tee";
            Session["price"] = 29.95;
            Session["image"] = "Images/image7.jpg";
            calculate();
        }

        protected void btnAddProduct2(object sender, EventArgs e)
        {
            Session["name"] = "Men's Blue Tee";
            Session["price"] = 49.95;
            Session["image"] = "Images/image5.jpg";
            calculate();
        }

        protected void btnAddProduct3(object sender, EventArgs e)
        {
            Session["name"] = "Men's White Tee";
            Session["price"] = 19.95;
            Session["image"] = "Images/image8.jpg";
            calculate();
        }

        protected void calculate()
        {
            double x = Convert.ToDouble(Session["total"]);
            double y = Convert.ToDouble(Session["price"]);
            Session["total"] = x + y;
            Response.Redirect("Cart.aspx");
        }

        protected void btncheckproduct1(object sender, EventArgs e)
        {
            Session["name"] = "Men's Green Striped Tee";
            Session["price"] = 29.95;
            Session["image"] = "Images/image7.jpg";
            Session["description"] = "Green Striped Tee made from cotton";
            Session["product"] = 1;
            Response.Redirect("Product.aspx");
        }

        protected void btncheckproduct2(object sender, EventArgs e)
        {
            Session["name"] = "Men's Blue Tee";
            Session["price"] = 49.95;
            Session["image"] = "Images/image5.jpg";
            Session["description"] = "Stylish and elegant design, made from real materials";
            Session["product"] = 2;
            Response.Redirect("Product.aspx");
        }

        protected void btncheckproduct3(object sender, EventArgs e)
        {
            Session["name"] = "Men's White Tee";
            Session["price"] = 19.95;
            Session["image"] = "Images/image8.jpg";
            Session["description"] = "Plain white t-shirt, perfect for a summers day";
            Session["product"] = 3;
            Response.Redirect("Product.aspx");
        }
    }
}