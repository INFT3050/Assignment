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
        public string ConString = WebConfigurationManager.ConnectionStrings["HMTconnect"].ConnectionString;
        SqlConnection con = new SqlConnection();
        

        
        public Customer find(int num)
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
                    if (rd.GetInt32(0) == num)
                    {
                        person.id = num;
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
            catch { throw; }

            person.firstName = "-1";
            con.Close();
            return person;
        }

        public Customer find(string email)
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
                    if (rd.GetString(3) == email)
                    {
                        person.id = rd.GetInt32(0);
                        person.firstName = rd.GetString(1);
                        person.lastName = rd.GetString(2);
                        person.email = email;
                        person.address = rd.GetString(4);
                        person.suspended = rd.GetBoolean(5);
                        con.Close();
                        return person;
                    }
                }
            }
            catch { throw; }

            person.firstName = "-1";
            con.Close();
            return person;
        }


        // Read(string email, string pass)
        // Checks if there is a customer in the database with correct email and password
        // returns 0 for nothing detected, 1 for correct email and 2 for both correct, therefore login.
        public int Read(string email, string pass)
        {
            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("select * from Client", con);
            SqlDataReader rd = cmd.ExecuteReader();

            //try
            {
                while (rd.Read())
                {
                    if (rd.GetString(3) == email)
                    {
                        int ID = rd.GetInt32(0);

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
            }
            //catch { throw; }

            con.Close();
            return 0;
        }

        //Inserts a new Customer in Customer Table
        public Int32 Insert(string Fname, string lName, string email, string address, string pass)
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

                return cmd.ExecuteNonQuery();
            }
            catch { throw; }
        }

        //returns all customers in a table format StringBuilder
        public StringBuilder getCustomers()
        {
            StringBuilder table = new StringBuilder();

            con.ConnectionString = ConString;
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("select * from Client", con);
            SqlDataReader rd = cmd.ExecuteReader();

            table.Append("<table border='1'>");
            table.Append("<tr><th>ID</th><th>First Name</th><th>Last Name</th><th>Email</th><th>Address</th><th>Suspended</th><th>update</th><th>Suspend</th>");
            table.Append("</tr>");

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    table.Append("<tr>");
                    table.Append("<td>" + rd[0] + "</td>");
                    table.Append("<td>" + rd[1] + "</td>");
                    table.Append("<td>" + rd[2] + "</td>");
                    table.Append("<td>" + rd[3] + "</td>");
                    table.Append("<td>" + rd[4] + "</td>");
                    table.Append("<td>" + rd[5] + "</td>");
                    table.Append("<td><button id=\"update\" runat=\"server\" OnClick=\"updateRecord_Click(" + rd[0] + ")\" text=\"update\" CausesValidation=\"false\"/>Update</button></td>");
                    table.Append(" <td><button id=\"suspend\" runat=\"server\" OnClick=\"suspendRecord_Click(" + rd[0] + ")\" text=\"suspend\" />Suspend</button></td>");
                }
            }

            table.Append("</table>");
            rd.Close();
            con.Close();

            return table;
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
            catch { throw; }
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

    }
}