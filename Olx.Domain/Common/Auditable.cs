﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olx.Domain.Common
{
    public class Auditable
    {
        public int Id { get; set; }

        public string IsCreated { get; set; } = DateTime.Now.ToString();
    }
}
