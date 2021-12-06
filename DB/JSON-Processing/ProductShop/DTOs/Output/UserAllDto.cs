using ProductShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductShop.DTOs.Output
{
    public class UserAllDto
    {
        public int UserCount { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}
