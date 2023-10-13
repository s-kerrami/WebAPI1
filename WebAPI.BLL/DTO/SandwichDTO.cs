﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.BLL.DTO
{
    public class SandwichDTO
    {
        public int SandwichId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public bool? IsVeggie { get; set; }
    }
}
