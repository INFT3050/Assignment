using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HMT.WebApp.BLL.App_Code;
using System.Text;
using HMT.WebApp.DAL.App_Code;

namespace HMT.WebApp.UL
{
    public partial class Search : System.Web.UI.Page
    {
        BuisnessLayer cust = new BuisnessLayer();
        StringBuilder table = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            table = cust.queryProducts(Session["search"].ToString());

            //converts html text to asp
            String raw_html = table.ToString();
            while (raw_html.IndexOf("**") != -1)
            {
                //Pre html content before button insertion
                string output = raw_html.Substring(0, raw_html.IndexOf("**"));
                raw_html = raw_html.Remove(0, raw_html.IndexOf("**") + 2);
                placeTable.Controls.Add(new Literal { Text = output });
               
                //dynamic creation of button
                String buttonID = raw_html.Substring(1, raw_html.IndexOf(")") - 1);
                Button buttonAddToCart = new Button();
                buttonAddToCart.Text = "Add to Cart ";
                buttonAddToCart.Click += new EventHandler(AddToCart);
                buttonAddToCart.CommandArgument = buttonID;

                placeTable.Controls.Add(buttonAddToCart);

                //remove the identifier from the raw_html
                raw_html = raw_html.Remove(0, raw_html.IndexOf(")") + 1);
            }

            //finally add the remainder of the raw_html
            placeTable.Controls.Add(new Literal { Text = raw_html });
        }

        protected void searchID_Click(object sender, EventArgs e)
        {

        }

        protected void AddToCart(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            System.Diagnostics.Debug.WriteLine(btn.CommandArgument);
        }
    }
}