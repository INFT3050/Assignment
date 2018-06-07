using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMT.WebApp.DAL.App_Code
{
    public class Cart
    {
        public int id           { get; set; }
        public List<Product> Product { get; set; }
        public string DateCreated  { get; set; }
    }
}