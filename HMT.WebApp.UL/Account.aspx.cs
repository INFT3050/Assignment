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
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Source account details from database and update asp labels
            if(Session["firstName"].ToString() == "-1" || Session["firstName"].ToString() == "")
                Response.Redirect("Sign_In.aspx");
            else
            {
                if (!IsPostBack)
                {
                    firstName.Text = Session["firstName"].ToString();
                    lName.Text = Session["lastName"].ToString();
                    eMail.Text = Session["email"].ToString();
                    password.Text = Session["password"].ToString();
                    address.Text = Session["address"].ToString();
                }
            }
        }

        protected void updateChanges_Click(object sender, EventArgs e)
        {
            BuisnessLayer control = new BuisnessLayer();
            Customer person = new Customer();

            person.firstName = firstName.Text;
            person.lastName = lName.Text;
            person.email = eMail.Text;
            person.address = address.Text;
            person.password = password.Text;

            control.updateChanges(person, Session["email"].ToString());

            Session["firstName"] = person.firstName;
            Session["lastName"] = person.lastName;
            Session["email"] = person.email;
            Session["address"] = person.address;
            Session["password"] = person.password;

            

            //Response.Redirect("Account.aspx");
        }
    }
}