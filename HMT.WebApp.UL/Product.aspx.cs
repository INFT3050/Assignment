using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMT.WebApp.UL
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MensTees cart = new MensTees();
        }

        protected void addtoCart(object sender, EventArgs e)
        {
            if(Session["product"].ToString() == "1")
            {
                Session["name"] = "Men's Green Striped Tee";
                Session["price"] = 29.95;
                Session["image"] = "Images/image7.jpg";
                calculate();
            }

            if (Session["product"].ToString() == "2")
            {
                Session["name"] = "Men's Blue Tee";
                Session["price"] = 49.95;
                Session["image"] = "Images/image5.jpg";
                calculate();
            }

            if (Session["product"].ToString() == "3")
            {
                Session["name"] = "Men's White Tee";
                Session["price"] = 19.95;
                Session["image"] = "Images/image8.jpg";
                calculate();
            }

            if (Session["product"].ToString() == "4")
            {
                Session["name"] = "Ladies Dress";
                Session["price"] = 99.95;
                Session["image"] = "Images/image1.jpg";
                calculate();
            }

            if (Session["product"].ToString() == "5")
            {
                Session["name"] = "Ladies Striped Sleeve";
                Session["price"] = 39.95;
                Session["image"] = "Images/image4.jpg";
                calculate();
            }
        }


        protected void calculate()
        {
            double x = Convert.ToDouble(Session["total"]);
            double y = Convert.ToDouble(Session["price"]);
            Session["total"] = x + y;
            Response.Redirect("Cart.aspx");
        }
    }
}