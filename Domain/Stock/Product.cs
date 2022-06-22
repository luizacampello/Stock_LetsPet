﻿using Stock.Domain.Common;
using System;
using System.Collections.Generic;
using Stock.Domain.Common;

namespace Stock.Domain.Stock
{
    public class Product
    {

        public Type Type { get; set; }       
        public Usage Usage { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int TotalVolume { get; set; }
        public int CurrentVolume { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Species Species { get; set; }

        
    }


}
