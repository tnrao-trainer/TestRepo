using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTestWebApiApplication.Models;

namespace MyTestWebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public IActionResult Get()
        {
            var prdList = new List<Product>() {
                new Product(){ ProductId = 1022, ProductName = "Printer", UnitPrice = 2400, Quantity = 5 },
                new Product(){ ProductId = 1023, ProductName = "Keyboard", UnitPrice = 1200, Quantity = 3 },
                new Product(){ ProductId = 1024, ProductName = "iBall Mouse", UnitPrice = 890, Quantity = 4 },
                new Product(){ ProductId = 1025, ProductName = "Boat Speakers", UnitPrice = 1900, Quantity = 6 },
                new Product(){ ProductId = 1026, ProductName = "DLink Router", UnitPrice = 1350, Quantity = 2 }
            };

            return Ok(prdList);
        }
    }
}
