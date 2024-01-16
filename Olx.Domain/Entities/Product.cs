using Olx.Domain.Common;
using Olx.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olx.Domain.Entities
{
    public class Product : Auditable
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public Category Category { get; set; }
         
        public string Inormation { get; set; }
    }
}
