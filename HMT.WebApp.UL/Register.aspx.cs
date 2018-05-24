using System;
using HMT.WebApp.BLL.App_Code;


namespace HMT.WebApp.UL
{
    public partial class Register : System.Web.UI.Page
    {

        BuisnessLayer cust = new BuisnessLayer();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["firstName"].ToString() != "" && Session["firstName"].ToString() != "-1")
            {
                Session["greeting"] = "Already Signed In";
                Response.Redirect("Default.aspx");
            }
        }

        protected void register_Click(object sender, EventArgs e)
        {
            Session["firstName"] = fname.Text;
            Session["lastName"] = lname.Text;
            Session["email"] = txtEmail.Text;
            Session["password"] = pass1.Text;
            Session["address"] = address.Text;

            cust.CreateCustomer(fname.Text, lname.Text, txtEmail.Text, pass1.Text, address.Text);




            Response.Redirect("Sign_In.aspx");
            
        }


    }
}