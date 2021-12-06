using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop.DTOs.Output
{
    public class UserProductDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? Age { get; set; }

        public ProductSoldDto SoldProducts { get; set; }
    }
}
