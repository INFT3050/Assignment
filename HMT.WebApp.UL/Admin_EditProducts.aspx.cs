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
    public partial class Admin_EditProducts : System.Web.UI.Page
    {
        BuisnessLayer cust = new BuisnessLayer();
        StringBuilder table = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            table = cust.getProducts();
            placeTable.Controls.Add(new Literal { Text = table.ToString() });
            hide.Visible = false;
        }

        protected void searchID_Click(object sender, EventArgs e)
        {
            int value;
            Product product = new Product();
            // checks if only a number
            if (!int.TryParse(search.Text, out value))
            {
                msgLbl.Text = "Please enter the ID only";
                search.BackColor = System.Drawing.Color.Red;
            }

            else
            {
                product = cust.getProduct(Convert.ToInt32(search.Text));
                if (product.name == "-1")
                {
                    msgLbl.Text = "Product does not exist";
                    search.BackColor = System.Drawing.Color.Orange;
                }
                else
                {
                    //hide.Visible = true;
                    search.BackColor = System.Drawing.Color.White;
                    msgLbl.Text = "";

                    name.Text = product.name;
                    description.Text = product.description;
                    size.Text = product.size;
                    price.Text = product.price.ToString();
                    image.Text = product.image;
                    gender.Text = product.gender;
                    hide.Visible = true;
                }
            }
        }

        protected void suspend_Click(object sender, EventArgs e)
        {
            Product temp = new Product();


            temp = cust.getProduct(Convert.ToInt32(search.Text));
            cust.suspendProduct(temp);
            Response.Redirect("Admin_EditCustomer.aspx");
        }

        protected void update_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.id = Convert.ToInt32(search.Text);
            product.name = name.Text;
            product.description = description.Text;
            product.size = size.Text;
            product.price = Convert.ToDecimal(price.Text);
            product.image = image.Text;
            product.gender = gender.Text;

            cust.updateProduct(product);
            Response.Redirect("Admin_EditProducts.aspx");
        }

        protected void insert_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.name = addName.Text;
            product.description = addDescription.Text;
            product.size = addSize.Text;
            product.price = Convert.ToDecimal(addPrice.Text);
            product.image = addImage.Text;
            product.gender = addGender.Text;

            cust.insertProduct(product);
            Response.Redirect("Admin_EditProducts.aspx");
        }
    }
}