﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortableClasses
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Manufacture { get; set; }
        public string Description { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
