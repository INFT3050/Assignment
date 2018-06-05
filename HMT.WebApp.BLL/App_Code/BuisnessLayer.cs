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
            int check = control.Read(email, pass);

            return check; 
        }

        // Passes a Customer to the DAL for insertion into the database
        public void CreateCustomer(string Fname, string lName, string email, string pass, string address)
        {
            DataAccessLayer newCustomer = new DataAccessLayer();
            newCustomer.Insert(Fname, lName, email, address, pass);
        }

        // returns the customer records in a table format
        public StringBuilder updateTable()
        {
            StringBuilder table = new StringBuilder();
            List<Customer> people = control.getCustomers();

            table.Append("<table border='0'>");
            table.Append("<tr><th>ID</th><th>First Name</th><th>Last Name</th><th>Email</th><th>Address</th><th>Suspended</th><th>update</th><th>Suspend</th>");
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
                table.Append("<td><button id='update' runat='server' OnClick='updateRecord_Click(" + item.id + ")' text='update'>Update</button></td>");
                table.Append(" <td><button id=\"suspend\" runat=\"server\" OnClick=\"suspendRecord_Click()\" text=\"suspend\" />Suspend</button></td>");
            }

            table.Append("</table>");

            return table;
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
            person = control.find(email);

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

        public StringBuilder queryProducts(string cmd)
        {
            StringBuilder table = new StringBuilder();
            List<Product> products = control.queryProducts(cmd);

            table.Append("<table border='0'>");

            foreach (var item in products)
            {
                table.Append("<tr><td><img style='width: auto; height: 400px' src = '" + item.image+ "'/></td></tr>");
                table.Append("<tr><td>" + item.name + "</td></tr>");
                table.Append("<tr><td>" + item.description + "</td></tr>");
                table.Append("<tr><td>" + item.size + "</td></tr>");
                table.Append("<tr><td>$" + item.price + "</td></tr>");
                table.Append("<tr><td><b>Product ID: " + item.id + "</b><hr></td></tr>");
            }

            table.Append("</table>");

            return table;


        }
    }
}