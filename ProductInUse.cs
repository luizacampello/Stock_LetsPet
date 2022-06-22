using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    internal class ProductInUse
    {
        public List<Product> OpenShampoo = new();
        public List<Product> OpenSpecialShampoo = new();
        public List<Product> OpenConditioner = new();
        public List<Product> OpenSpecialConditioner = new();
        public List<Product> OpenPerfume = new();
        public List<Product> OpenSpecialPerfume = new();
    }
}
