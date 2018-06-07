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
    public partial class ShowCart : System.Web.UI.Page
    {
        BuisnessLayer cust = new BuisnessLayer();
        StringBuilder table = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"].ToString() == "0")
                Response.Redirect("Sign_In.aspx");
            else
            {
                table = cust.getCart(Convert.ToInt32(Session["ID"]));

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
                    buttonAddToCart.Text = "Remove From Cart";
                    buttonAddToCart.Click += new EventHandler(rmvFromCart_Click);
                    buttonAddToCart.CommandArgument = buttonID;

                    placeTable.Controls.Add(buttonAddToCart);

                    //remove the identifier from the raw_html
                    raw_html = raw_html.Remove(0, raw_html.IndexOf(")") + 1);
                }

                //finally add the remainder of the raw_html
                placeTable.Controls.Add(new Literal { Text = raw_html });
            }
        }

        protected void rmvFromCart_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            cust.RemoveItemFromCart(Convert.ToInt32(Session["ID"]) , Convert.ToInt32(btn.CommandArgument));
            Response.Redirect("ShowCart.aspx");
        }
    }
}