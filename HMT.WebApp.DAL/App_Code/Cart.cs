﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMT.WebApp.DAL.App_Code
{
    public class Cart
    {
        public int id           { get; set; }
        public List<Item> products { get; set; }
        public string DateCreated  { get; set; }
        public bool IsActive { get; set; }

    }
}