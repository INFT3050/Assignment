using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMT.WebApp.DAL.App_Code
{
    //Customer Class
    //      Stores data for a customer object 


    public class Customer
    {
        public int id           { get; set; }
        public string firstName    { get; set; }
        public string lastName     { get; set; }
        public string email        { get; set; }
        public bool suspended        { get; set; }
        public string address      { get; set; }
        public string password { get; set; }
    }
}