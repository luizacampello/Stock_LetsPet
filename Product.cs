using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public class Product
    {
        public string BarCode { get; set; }
        public Services ServiseUse { get; set; }
        public string Name { get; set; }
        public TipoProdutos Tipo { get; set; }
        public bool Special { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public double NetWeight { get; set; }
        public double NetWeightRest { get; set; }
        public DateTime ExperationDate { get; set; }
        public bool OpenProduct { get; set; }
        public DateTime DataCadastro { get; } = DateTime.Now;
    }
}
