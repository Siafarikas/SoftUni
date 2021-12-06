using ProductShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop.DTOs.Output
{
    public class ProductSoldDto
    {
        public int Count { get; set; }

        public ProductAllDto[] Products { get; set; }
    }
}
