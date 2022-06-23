using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Stock
{
    internal class ProductRegistration
    {
        Product newProduct = new Product();
        private int minAmount = 2;
        private int maxAmount = 20;

        void NewProductRegistry()
        {
            Product newProduct = new();
            newProduct.Category = newProductCategory();
            newProduct.Usage = newProductUsage();
            newProduct.Name = newProductName();
            newProduct.Brand = newProductBrand();
        }
    }

}

