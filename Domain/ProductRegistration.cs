using Stock.Domain.Common;
using Stock.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain
{
    public class ProductRegistration
    {
        private int minAmount = 2;
        private int maxAmount = 20;

        public static Product NewProductPropertiesRegistry()
        {
            Category newProductCategory = InputServices.SelectCategory();
            int newProductQuantity = InputServices.NewQuantity();
            Usage newProductUsage = InputServices.SelectUsage();
            string newProductName = InputServices.NewName();
            string newProductBrand = InputServices.NewBrand();
            decimal newProductPrice = InputServices.NewPrice();
            int newProductTotalVolume = InputServices.NewTotalVolume();
            DateTime newProductExpirationDate = InputServices.NewExpirationDate();
            Species newProductSpecies = InputServices.SelectSpecies();
            Product newProduct = new Product(newProductCategory, newProductUsage, newProductName, newProductBrand, newProductPrice,
                                             newProductTotalVolume, newProductExpirationDate, newProductSpecies);
            return newProduct;
        }

        public static void AddNewProductToStock(Product newProduct, Stock petStock)
        {
            petStock.AddToStock(newProduct);
        }

        public int AllowedQuantityByCategory(Stock petStock, Category newProductCategory)
        {
            return maxAmount - petStock.ProductCategoryQuantity(newProductCategory);
        }

    }

}

