using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMT.WebApp.UL
{
    public partial class Womens_Tees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddProduct1(object sender, EventArgs e)
        {
            Session["name"] = "Ladies Dress";
            Session["price"] = 99.95;
            Session["image"] = "Images/image1.jpg";
            calculate();
        }

        protected void btnAddProduct2(object sender, EventArgs e)
        {
            Session["name"] = "Ladies Striped Sleeve";
            Session["price"] = 39.95;
            Session["image"] = "Images/image4.jpg";
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
            Session["name"] = "Ladies Dress";
            Session["price"] = 99.95;
            Session["image"] = "Images/image1.jpg";
            Session["description"] = "Beautiful dress for long walks on the beach";
            Session["product"] = 4;
            Response.Redirect("Product.aspx");
        }

        protected void btncheckproduct2(object sender, EventArgs e)
        {
            Session["name"] = "Ladies Striped Sleeve";
            Session["price"] = 39.95;
            Session["image"] = "Images/image4.jpg";
            Session["description"] = "Stylish and elegant design, made from real materials";
            Session["product"] = 5;
            Response.Redirect("Product.aspx");
        }
    }
}