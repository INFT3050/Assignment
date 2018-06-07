using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMT.WebApp.DAL.App_Code
{
    public class Item
    {
        public int id { get; set; }
        public int product { get; set; }
        public int quantity { get; set; }
        public int cartID { get; set; }
        public bool IsActive { get; set; }
    }
}