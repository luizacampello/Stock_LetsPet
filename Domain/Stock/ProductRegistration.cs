using Stock.Domain.Common;
using Stock.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Stock
{
    public class ProductRegistration
    {
        private int minAmount = 2;
        private int maxAmount = 20;

        public Product NewProductRegistry()
        {
            Category newProductCategory = InputValidationAndFormat.SelectCategory();
            Usage newProductUsage = InputValidationAndFormat.SelectUsage();
            string newProductName = InputValidationAndFormat.NewName();
            string newProductBrand = InputValidationAndFormat.NewBrand();
            decimal newProductPrice = InputValidationAndFormat.NewPrice();
            int newProductTotalVolume = InputValidationAndFormat.NewTotalVolume();
            DateTime newProductExpirationDate = InputValidationAndFormat.NewExpirationDate();
            Species newProductSpecies = InputValidationAndFormat.SelectSpecies();
            Product newProduct = new Product(newProductCategory, newProductUsage, newProductName, newProductBrand, newProductPrice, 
                                             newProductTotalVolume, newProductExpirationDate, newProductSpecies);
            return newProduct;
        }

        public void AddNewProductToStock(Product newProduct, Stock petStock)
        {
            petStock.AddToStock(newProduct);
        }

       
    }

}

