﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UberFoodsAPI.Models
{
    public class Article
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
