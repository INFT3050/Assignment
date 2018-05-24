using HMT.WebApp.DAL.App_Code;
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
            return control.getCustomers();
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
    }
}