using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HMT.WebApp.BLL.App_Code;
using HMT.WebApp.DAL.App_Code;

namespace HMT.WebApp.UL
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        BuisnessLayer customer = new BuisnessLayer();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitPass_Click(object sender, EventArgs e)
        {
            if (password1.Text == password2.Text)
            {
                Customer person = customer.getCustomer(Session["ForgotPassword"].ToString());
                person.password = password1.Text;
                customer.updateChanges(person, Session["ForgotPassword"].ToString());

                Response.Redirect("Sign_In.aspx");
            }
            else
            {
                errorLabel.Text = "Passwords do not match";
            }
        }
    }
}