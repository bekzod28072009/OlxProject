﻿using Olx.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olx.Domain.Entities
{
    public class User : Auditable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public List<Product> Products { get; set; }

        public User()
        {
            Products = new List<Product>();
        }
    }
}
