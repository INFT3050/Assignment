using HMT.WebApp.BLL.App_Code;
using HMT.WebApp.DAL.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMT.WebApp.UL
{
    public partial class Payment : System.Web.UI.Page
    {
        BuisnessLayer payment = new BuisnessLayer();


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            // makes the payment with the current items in the cart and the customer
            int customer = Convert.ToInt32(Session["ID"]);
            int cartID = payment.getCartID(customer);
            payment.makePayment(cartID, customer);

            Customer payCustomer = payment.getCustomer(customer);
            List<Item> paidCart = payment.getItemsFromCart(cartID);

            MailMessage message = new MailMessage("customerservice@ausfashion.com", Session["email"].ToString(), "Order Recieved '" + DateTime.Now + "'", "");

            String msg = "";

            msg = msg + "<style> td, th { text-align:left; padding: 8px;}</style>";

            msg = msg + "<div>Hi " + fname.Value + ",</div>";
            msg = msg + "<div>Thank you for shopping with AusFashion, we hope you come back soon! Below is everything you need to know about your order. </div>";
            msg = msg + "<div>Thankyou, <br> AusFashion</div><br><hr>";
            
            //Delivery address
            msg = msg + "<b>Delivery Address:</b><br> " + street.Value + " " + road.Value + " " + town.Value + ",<br> " + postcode.Value + " Australia";
            msg = msg + "<br>" + payCustomer.email;
            
            //Products in the cart
            msg = msg + "<table>";
            msg = msg + "<tr><th width=400px;>Product</th><th>Qty</th><th>Price</th></tr>";
            message.IsBodyHtml = true;
            foreach (Item itemP in paidCart)
            {
                Product product = payment.getProduct(itemP.product);
                msg = msg + "<tr><td>" + product.name + "</td><td>" + itemP.quantity + "</td><td>$" + itemP.quantity*product.price + "</td></tr>";
            }

            msg = msg + "<tr><td></td><td><b>Total Cost:</b></td><td>$" + Session["Total"] + "</td></tr>";
            msg = msg + "</table>";
            msg = msg + "<br><hr>";

            // Billing information
            msg = msg + "<b>Billing Method: </b><br>Paid With: ***Credit Card***<br>Email Address: " + payCustomer.email + "<br>Amount: $" + Session["Total"] +"<br>Trasaction Reference: " + DateTime.Now;

            
            message.Body = msg;

            SmtpClient client = new SmtpClient("127.0.0.1", 25);
            client.Send(message);







            Response.Redirect("PaymentSent.aspx");
        }
    }
}