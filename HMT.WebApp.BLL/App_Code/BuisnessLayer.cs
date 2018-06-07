using System;
using HMT.WebApp.DAL.App_Code;
using System.Collections.Generic;
using System.Text;

namespace HMT.WebApp.BLL.App_Code
{
    public class BuisnessLayer
    {
        DataAccessLayer control = new DataAccessLayer();

        // Passes email and password to the DAL for verification of a login and returns whether user login was successful or not
        public int CheckLogin(string email, string pass)
        {
            int check = control.SignIn(email, pass);

            return check; 
        }

        // Passes a Customer to the DAL for insertion into the database
        public void CreateCustomer(string Fname, string lName, string email, string pass, string address)
        {
            DataAccessLayer newCustomer = new DataAccessLayer();
            newCustomer.Insert(Fname, lName, email, address, pass);
        }
        
        // returns the person with the specified ID
        public Customer getCustomer(int id)
        {
            Customer person = new Customer();
            person = control.find(id);

            return person;
        }

        // returns person with email address
        public Customer getCustomer(string email)
        {
            Customer person = new Customer();
            person = control.find(-1, email);

            return person;
        }

        public void updateChanges(Customer person, string email)
        {
            control.update(person, email);
        }

        public void suspendCustomer(Customer person)
        {
            control.suspend(person);
        }

        public Product getProduct(int id)
        {
            return control.findProduct(id);
        }

        public void updateProduct(Product change)
        {
            control.update(change);
        }

        // String builder tables
        // returns the customer records in a table format
        public StringBuilder updateTable()
        {
            StringBuilder table = new StringBuilder();
            List<Customer> people = control.getCustomers();

            table.Append("<table border='1'>");
            table.Append("<tr><th>ID</th><th>First Name</th><th>Last Name</th><th>Email</th><th>Address</th><th>Suspended</th>");
            table.Append("</tr>");

            foreach (var item in people)
            {
                table.Append("<tr>");
                table.Append("<td>" + item.id + "</td>");
                table.Append("<td>" + item.firstName + "</td>");
                table.Append("<td>" + item.lastName + "</td>");
                table.Append("<td>" + item.email + "</td>");
                table.Append("<td>" + item.address + "</td>");
                table.Append("<td>" + item.suspended + "</td>");
            }

            table.Append("</table>");

            return table;
        }

        public StringBuilder queryProducts(string cmd)
        {
            StringBuilder table = new StringBuilder();
            List<Product> products = control.queryProducts(cmd);

            table.Append("<div class='grid'>");

            foreach (var item in products)
            {
                table.Append("<div class='flexbox-container'><div><img style='width: auto; height: 400px' src = '" + item.image + "'/></div>");
                table.Append("<p>" + item.name + "</p>");
                table.Append("<p>" + item.description + "</p>");
                table.Append("<p>" + item.size + "</p>");
                table.Append("<p>$" + item.price + "</p>");
                table.Append("**(" + item.id + ")</div>");
            }

            table.Append("</div>");

            return table;
        }

        public StringBuilder getProducts()
        {
            StringBuilder table = new StringBuilder();
            List<Product> people = control.queryProducts("select * from Product");

            table.Append("<table border='1'>");
            table.Append("<tr><th>ID</th><th>Product Name</th><th>Product Description</th><th>Product Size</th><th>Price</th><th>Image</th><th>Gender</th>");
            table.Append("</tr>");

            foreach (var item in people)
            {
                table.Append("<tr>");
                table.Append("<td>" + item.id + "</td>");
                table.Append("<td>" + item.name + "</td>");
                table.Append("<td>" + item.description + "</td>");
                table.Append("<td>" + item.size + "</td>");
                table.Append("<td>" + item.price + "</td>");
                table.Append("<td>" + item.image + "</td>");
                table.Append("<td>" + item.gender + "</td>");
            }

            table.Append("</table>");

            return table;
        }

        public void AddToCartItems(int productID, int customerID) //INCOMPLETE
        {
            // Get customer's cartID from their customerID.
            int cartID = control.FindCartID(customerID);

            // Call DAL to insert into database. If statement guards against error cases.
            if (cartID != -1)
            {
                control.InsertCartItem(productID, cartID);
            }
        }

        public void RemoveItemFromCart(int btn, int custID)
        {
            int cartID = control.FindCartID(custID);
            control.RemoveCartItem(btn ,cartID);
        }

        public StringBuilder getCart(int custID)
        {
            StringBuilder table = new StringBuilder();
            int cartID = control.FindCartID(custID);
            Cart tempCart = control.getCart(cartID);
            List<Item> products = tempCart.products;

            decimal total = 0;
            foreach (var itemP in products)
            {
                List<Product> temp = control.queryProducts("select * from Product where ProductID = '" + itemP.product + "'");
                Product item = temp[0];

                table.Append("<div class='grouping'><img class='edit' src = '" + item.image + "'/>");
                table.Append("<div>" + item.name + "</div>");
                table.Append("<div>" + item.size + "</div>");
                table.Append("<div>Quantity: " + itemP.quantity + "</div>");
                table.Append("<div>$" + item.price + "</div>");
                table.Append("<div>**(" + item.id + ")</div></div>");
                total = total + itemP.quantity*item.price;
            }
            table.Append("<h2>Total: $" + total + "</h2>");

            return table;
        }
    }
}