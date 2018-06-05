using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMT.WebApp.DAL.App_Code
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string size { get; set; }
        public decimal price { get; set; }
        public string image { get; set; }
        public string gender { get; set; }
    }
}