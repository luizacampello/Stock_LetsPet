using Stock.Domain.Common;
using System;
using System.Collections.Generic;

namespace Stock.Domain.Stock
{
    public class Product
    {

        public Category Category { get; set; }
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
