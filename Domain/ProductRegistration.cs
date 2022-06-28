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
        private Stock storage;

        public ProductRegistration(Stock storage)
        {
            this.storage = storage;
        }

        public Product NewProductProperties()
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
        public void NewProductRegistry()
        {
            Category newProductCategory = InputServices.SelectCategory();
            int allowedQuantity = AllowedQuantityByCategory(newProductCategory);
            int newProductQuantity = InputServices.NewQuantity();
        }

        public void AddNewProductToStock(Product newProduct)
        {
            storage.AddToStock(newProduct);
        }

        private int AllowedQuantityByCategory(Category newProductCategory)
        {
            return maxAmount - storage.ProductCategoryQuantity(newProductCategory);
        }

    }

}

