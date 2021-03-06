﻿using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using HMT.WebApp.BLL.App_Code;
using System.Text;
using HMT.WebApp.DAL.App_Code;

namespace HMT.WebApp.UL
{
    public partial class Admin_EditCustomer : System.Web.UI.Page
    {
        BuisnessLayer cust = new BuisnessLayer();
        StringBuilder table = new StringBuilder();
        //
        //
        protected void Page_Load(object sender, EventArgs e)
        {
            table = cust.updateTable();
            placeTable.Controls.Add(new Literal { Text = table.ToString() });
            hide.Visible = false;
        }

        protected void searchID_Click(object sender, EventArgs e)
        {
            int value;
            Customer person = new Customer();
            // checks if only a number
            if (!int.TryParse(search.Text, out value))
            {
                msgLbl.Text = "Please enter the ID only";
                search.BackColor = System.Drawing.Color.Red;
            }

            else
            {
                person = cust.getCustomer(Convert.ToInt32(search.Text));
                if (person.firstName == "-1")
                {
                    msgLbl.Text = "Customer does not exist";
                    search.BackColor = System.Drawing.Color.Orange;
                }
                else
                {
                    //hide.Visible = true;
                    search.BackColor = System.Drawing.Color.White;
                    msgLbl.Text = "";

                    first.Text = person.firstName;
                    last.Text = person.lastName;
                    email.Text = person.email;
                    address.Text = person.address;
                    suspended.Text = person.suspended.ToString();
                    Session["email"] = person.email;
                    hide.Visible = true;
                }
            }
        }

        protected void suspend_Click(object sender, EventArgs e)
        {
            Customer temp = new Customer();

            
            temp = cust.getCustomer(Convert.ToInt32(search.Text));
            cust.suspendCustomer(temp);
            Response.Redirect("Admin_EditCustomer.aspx");
            
        }

        protected void updateRecord_Click(object sender, EventArgs e)
        {
            search.Text = "OMG";
        }

        protected void update_Click(object sender, EventArgs e)
        {
            Customer person = new Customer();

            person.firstName = first.Text;
            person.lastName = last.Text;
            person.email = email.Text;
            person.address = address.Text;
            if(suspended.Text == "False")
                person.suspended = false;
            else
                person.suspended = true;
            cust.updateChanges(person, Session["email"].ToString());
            Response.Redirect("Admin_EditCustomer.aspx");
            
        }
    }
}