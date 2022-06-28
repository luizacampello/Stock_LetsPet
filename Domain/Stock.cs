using Stock.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain
{
    public class Stock
    {
        public List<Product> StoredShampoo { get; private set; } = new();
        public List<Product> StoredConditioner { get; private set; } = new();
        public List<Product> StoredPerfume { get; private set; } = new();

        public List<Product> GetFullStock()
        {
            List<Product> fullStock = StoredShampoo.Concat(StoredConditioner).Concat(StoredPerfume).ToList();
            return fullStock;
        }

        public int ProductCategoryQuantity(Category productType)
        {
            switch (productType)
            {
                case Category.Shampoo:
                    return StoredShampoo.Count;
                case Category.Conditioner:
                    return StoredConditioner.Count;
                case Category.Perfume:
                    return StoredPerfume.Count;
                default:
                    break;
            }
            return 0;
        }

        public void AddToStock(Product newProduct)
        {
            switch (newProduct.Category)
            {
                case Category.Shampoo:
                    StoredShampoo.Add(newProduct);
                    StoredShampoo.Sort((x, y) => x.ExpirationDate.CompareTo(y.ExpirationDate));
                    return;
                case Category.Conditioner:
                    StoredConditioner.Add(newProduct);
                    StoredConditioner.Sort((x, y) => x.ExpirationDate.CompareTo(y.ExpirationDate));
                    return;
                case Category.Perfume:
                    StoredPerfume.Add(newProduct);
                    StoredPerfume.Sort((x, y) => x.ExpirationDate.CompareTo(y.ExpirationDate));
                    return;
                default:
                    break;
            }
        }

        public Product RemoveFromStock(Category productType, Usage wantedProductUsage, Species wantedProductSpecies)
        {
            int productIndex = -1;
            Product newProduct = new();

            switch (productType)
            {
                case Category.Shampoo:
                    productIndex = SearchWantedProduct(StoredShampoo, wantedProductUsage, wantedProductSpecies);
                    return StoredShampoo.Pop(productIndex);
                case Category.Conditioner:
                    productIndex = SearchWantedProduct(StoredConditioner, wantedProductUsage, wantedProductSpecies);
                    return StoredConditioner.Pop(productIndex);
                case Category.Perfume:
                    productIndex = SearchWantedProduct(StoredPerfume, wantedProductUsage, wantedProductSpecies);
                    return StoredPerfume.Pop(productIndex);

                default:
                    break;
            }
            return newProduct;
        }

        private static int SearchWantedProduct(List<Product> CategoryStock, Usage wantedProductUsage, Species wantedProductSpecies)
        {
            int productIndex = -1;

            for (int i = 0; i < CategoryStock.Count; i++)
            {
                var product = CategoryStock[i];
                if (product.Usage == wantedProductUsage && product.Species == wantedProductSpecies)
                {
                    productIndex = i;
                    break;
                }
            }

            return productIndex;
        }

    }
}
