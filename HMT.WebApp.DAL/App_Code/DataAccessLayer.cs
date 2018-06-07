﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace HMT.WebApp.DAL.App_Code
{
    public class DataAccessLayer
    {
        private string ConString = WebConfigurationManager.ConnectionStrings["HMTconnect"].ConnectionString;
        SqlConnection con = new SqlConnection();
        

        
        public Customer find(int num = -1, string email = "")
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("select * from Client", con);
            SqlDataReader rd = cmd.ExecuteReader();
            Customer person = new Customer();

            try
            {
                while (rd.Read())
                {
                    if (rd.GetInt32(0) == num || rd.GetString(3) == email)
                    {
                        person.id = rd.GetInt32(0);
                        person.firstName = rd.GetString(1);
                        person.lastName = rd.GetString(2);
                        person.email = rd.GetString(3);
                        person.address = rd.GetString(4);
                        person.suspended = rd.GetBoolean(5);
                        con.Close();
                        return person;
                    }
                }
            }
            catch { }

            person.firstName = "-1";
            con.Close();
            return person;
        }

        public Product findProduct(int id)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("select * from Product", con);
            SqlDataReader rd = cmd.ExecuteReader();
            Product product = new Product();

            try
            {
                while (rd.Read())
                {
                    if (rd.GetInt32(0) == id)
                    {
                        product.id = rd.GetInt32(0);
                        product.name = rd.GetString(1);
                        product.description = rd.GetString(2);
                        product.size = rd.GetString(3);
                        product.price = rd.GetDecimal(4);
                        product.image = rd.GetString(5);
                        product.gender = rd.GetString(6);
                        con.Close();
                        return product;
                    }
                }
            }
            catch { }

            product.name = "-1";
            con.Close();
            return product;
        }

        // Read(string email, string pass)
        // Checks if there is a customer in the database with correct email and password
        // returns 0 for nothing detected, 1 for correct email and 2 for both correct, therefore login, 3 for suspended account, 4 for admin privileges.
        public int Read(string email, string pass)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("select * from ClientAdmin where Username = '" + email + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                if (rd.GetString(2) == pass)
                {
                    con.Close();
                    return 4;
                }
            }

            rd.Close();
            cmd = new SqlCommand("select * from Client", con);
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                if (rd.GetString(3) == email)
                {
                    int ID = rd.GetInt32(0);

                    if (rd.GetBoolean(5))
                    {
                        con.Close();
                        return 3;
                    }

                    //sql command to search for customer with the ID specified
                    cmd = new SqlCommand("select * from ClientPassword where ClientID = " + ID + "", con);
                    rd.Close();
                    SqlDataReader pa = cmd.ExecuteReader();

                    if (pa.Read() && pa.GetString(2) == pass)
                    {
                        pa.Close();
                        con.Close();
                        return 2;
                    }
                    else
                    {
                        pa.Close();
                        con.Close();
                        return 1;
                    }
                }
            }

            con.Close();
            return 0;
        }

        //Inserts a new Customer in Customer Table
        public void Insert(string Fname, string lName, string email, string address, string pass)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            try
            {
                //Sql commands for adding a new customer into the database
                SqlCommand cmd = new SqlCommand("INSERT INTO Client VALUES (@FirstName,@LastName,@Email,@CustomerAddress,@suspended)", con);
                cmd.Parameters.AddWithValue("@FirstName", Fname);
                cmd.Parameters.AddWithValue("@LastName", lName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@CustomerAddress", address);
                cmd.Parameters.AddWithValue("@suspended", '0');

                cmd.ExecuteNonQuery();

                int ID = 0; ;
                cmd = new SqlCommand("select * from Client", con);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (rd.GetString(3) == email)
                    {
                        ID = rd.GetInt32(0);
                        break;
                    }
                }
                rd.Close();

                cmd = new SqlCommand("INSERT INTO ClientPassword VALUES (@ClientID,@password)", con);

                cmd.Parameters.AddWithValue("@ClientID", ID);
                cmd.Parameters.AddWithValue("@password", pass);

                cmd.ExecuteNonQuery();
            }
            catch { }
        }

        //returns all customers in a List
        public List<Customer> getCustomers()
        {
            List<Customer> people = new List<Customer>();

            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("select * from Client", con);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Customer temp = new Customer();
                    temp.id = Convert.ToInt32(rd[0]);
                    temp.firstName = rd[1].ToString();
                    temp.lastName = rd[2].ToString();
                    temp.email = rd[3].ToString();
                    temp.address = rd[4].ToString();
                    temp.suspended = rd.GetBoolean(5);
                    people.Add(temp);
                }
            }

            rd.Close();
            con.Close();

            return people;
        }

        // Update customer records
        public void update(Customer person, string email)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("select * from Client where ([Email] = '" + email + "')", con);
                SqlDataReader rd = cmd.ExecuteReader();
                int id = 0;
                if (rd.Read())
                    id = rd.GetInt32(0);

                rd.Close();
                cmd = new SqlCommand("UPDATE Client SET FirstName = @FirstName, LastName = @LastName, Email = @Email, CustomerAddress = @address, Suspended = @suspended WHERE (ClientID = '" + id + "')", con);
                cmd.Parameters.AddWithValue("@FirstName", person.firstName);
                cmd.Parameters.AddWithValue("@LastName", person.lastName);
                cmd.Parameters.AddWithValue("@Email", person.email);
                cmd.Parameters.AddWithValue("@address", person.address);
                cmd.Parameters.AddWithValue("@suspended", person.suspended);

                cmd.ExecuteNonQuery();
                if (person.password != null)
                {
                    cmd = new SqlCommand("UPDATE ClientPassword SET password = @password WHERE (ClientID = '" + id + "')", con);
                    cmd.Parameters.AddWithValue("@password", person.password);

                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch { }
        }

        public void update(Product product)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            {
                SqlCommand cmd = new SqlCommand("UPDATE Product SET ProductNAME = @name, ProductDescription = @description, ProductSize = @size, Price = @price, Image = @image, Gender = @gender WHERE (ProductID = '" + product.id + "')", con);
                cmd.Parameters.AddWithValue("@name", product.name);
                cmd.Parameters.AddWithValue("@description", product.description);
                cmd.Parameters.AddWithValue("@size", product.size);
                cmd.Parameters.AddWithValue("@price", product.price);
                cmd.Parameters.AddWithValue("@image", product.image);
                cmd.Parameters.AddWithValue("@gender", product.gender);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void suspend(Customer person)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Client SET Suspended = @suspended WHERE (ClientID = '" + person.id + "')", con);
                if(!person.suspended)
                    cmd.Parameters.AddWithValue("@suspended", '1');
                else
                    cmd.Parameters.AddWithValue("@suspended", '0');
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch { throw; }
        }


        public List<Product> queryProducts(string command)
        {
            List<Product> products = new List<Product>();

            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand(command, con);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Product temp = new Product();
                    temp.id = Convert.ToInt32(rd[0]);
                    temp.name = rd[1].ToString();
                    temp.description = rd[2].ToString();
                    temp.size = rd[3].ToString();
                    temp.price = rd.GetDecimal(4);
                    temp.image = rd[5].ToString();
                    temp.gender = rd[6].ToString();
                    products.Add(temp);
                }
            }

            rd.Close();
            con.Close();

            return products;
        }

        public void InsertCartItem(int ProductID, int Quantity, int CartID)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            try
            {
                // Insert new row into table CartItems.
                SqlCommand cmd = new SqlCommand("INSERT INTO CartItems VALUES (@ProductID,@Quantity,@CartID)", con);
                cmd.Parameters.AddWithValue("@ProductID", ProductID);
                cmd.Parameters.AddWithValue("@Quantity", Quantity);
                cmd.Parameters.AddWithValue("@CartID", CartID);
                cmd.ExecuteNonQuery();
            }
            catch { }
        }

        public void InsertCartItem(int ProductID, int CartID)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            try
            {
                int currentQuantity = 0; 
                SqlCommand cmd = new SqlCommand("SELECT * FROM CartItems", con);
                SqlDataReader rd = cmd.ExecuteReader();

                // Search CartItems table and find the quantity of the selected item matching both cartID and productID.
                bool quantityFound = false;
                while (rd.Read())
                {
                    if (rd.GetInt32(0) == ProductID && rd.GetInt32(2) == CartID)
                    {
                        if (rd.GetSqlBoolean(4).Equals(0)) { currentQuantity = 0; }
                        else { currentQuantity = rd.GetInt32(1);}
                        
                        quantityFound = true;
                        break;
                    }
                }
                rd.Close();

                // If an existing quantity is found then update the current quantity.
                if (quantityFound == true)
                {
                    cmd = new SqlCommand("UPDATE CartItems SET Quantity = @Quantity WHERE (ProductID = @ProductID AND CartID = @CartID)", con);
                    cmd.Parameters.AddWithValue("@ProductID", ProductID);
                    cmd.Parameters.AddWithValue("@Quantity", currentQuantity + 1);  // Increments the quantity.
                    cmd.Parameters.AddWithValue("@CartID", CartID);
                    cmd.ExecuteNonQuery();
                }

                // If no current quantity was found, then insert a new row into table CartItem.
                else
                {
                    InsertCartItem(ProductID, 1, CartID);
                }
            }
            catch { }
        }

        public void RemoveCartItem (int ProductID, int CartID)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            try
            {
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM CartItems", con);
                SqlDataReader rd = cmd.ExecuteReader();

                // Soft deletes CartItems by setting isActive to 0 (false).
                cmd = new SqlCommand("UPDATE CartItems SET isActive = 0 WHERE (ProductID = @ProductID AND CartID = @CartID)", con);
                cmd.Parameters.AddWithValue("@ProductID", ProductID);
                cmd.Parameters.AddWithValue("@CartID", CartID);
                cmd.ExecuteNonQuery();
                
            }
            catch { }
        }

        public void ReduceCartItemQuantity(int ProductID, int CartID)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();
            try
            {
                int currentQuantity = 0;
                SqlCommand cmd = new SqlCommand("SELECT * FROM CartItems", con);
                SqlDataReader rd = cmd.ExecuteReader();

                // Search CartItems table and find the quantity of the selected item matching both cartID and productID.
                bool quantityFound = false;
                while (rd.Read())
                {
                    if (rd.GetInt32(0) == ProductID && rd.GetInt32(2) == CartID)
                    {
                        currentQuantity = rd.GetInt32(1);
                        quantityFound = true;
                        break;
                    }
                }
                rd.Close();

                // If an existing quantity is found then update the current quantity.
                if (quantityFound == true)
                {
                    cmd = new SqlCommand("UPDATE CartItems SET Quantity = @Quantity WHERE (ProductID = @ProductID AND CartID = @CartID)", con);
                    cmd.Parameters.AddWithValue("@ProductID", ProductID);
                    cmd.Parameters.AddWithValue("@Quantity", currentQuantity - 1);  // Decrements the quantity.
                    cmd.Parameters.AddWithValue("@CartID", CartID);
                    cmd.ExecuteNonQuery();
                }

                // If no current quantity was found, then soft delete the item from the table.
                else
                {
                    RemoveCartItem(ProductID, CartID);
                }
            }
            catch { }
        }

        public int FindCartID (int customerID)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT CartID FROM ShoppingCart WHERE CustomerID = @custID", con);
                cmd.Parameters.AddWithValue("@custID", customerID);
                SqlDataReader rd = cmd.ExecuteReader();

           
                while (rd.Read()) 
                {
                    con.Close();
                    return (int)rd.GetInt32(0);
                }
            }
            catch { }
            return -1;  // This should only occur if there is an error within the Try-Catch block, there is no soft-fail option available.
        }
    }
}