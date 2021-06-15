﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyTestWebApiApplication.Models
{
    public class Product
    {       
        public int ProductId { get; set; }        
        public string ProductName { get; set; }        
        public int Quantity { get; set; }        
        public double UnitPrice { get; set;  }
    }
}
