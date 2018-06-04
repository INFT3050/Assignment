using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HMT.WebApp.BLL.App_Code;
using HMT.WebApp.DAL.App_Code;
using System.Net.Mail;

namespace HMT.WebApp.UL
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        BuisnessLayer cust = new BuisnessLayer();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitEmail_Click(object sender, EventArgs e)
        {
            Customer temp;
            temp = cust.getCustomer(txtEmail.Text);
            if(temp.firstName == "-1")
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Invalid Email Address";
            }

            else
            {
                Session["ForgotPassword"] = txtEmail.Text;

                MailMessage message = new MailMessage("customerservice@ausfashion.com", txtEmail.Text, "Reset Password", "");
                message.Body = "To reset your password click on the following link http://localhost:55800/ResetPassword.aspx";

                SmtpClient client = new SmtpClient("127.0.0.1", 25);
                client.Send(message);
                

                Response.Redirect("ForgotPasswordSent.aspx");
            }
        }
    }
}