using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMT.WebApp.DAL.App_Code
{
    public class Payment
    {
        public int id { get; set; }
        public List<Cart> carts { get; set; }
        public int cartid { get; set; }
        public int customerid { get; set; }
        public int date { get; set; }
        public int totalCost { get; set; }
    }
}