using Stock.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Stock
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

        void AddToStock(Product newProduct)
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

        Product RemoveFromStock(Category productType, Usage wantedProductUsage, Species wantedProductSpecies)
        {
            int productIndex = -1 ;
            Product ProductToOpen = new();

            switch (productType)
            {
                case Category.Shampoo:
                    productIndex = ProductSearchSelection(StoredShampoo, wantedProductUsage, wantedProductSpecies);
                    ProductToOpen = StoredShampoo[productIndex];
                    StoredShampoo.RemoveAt(productIndex);
                    return ProductToOpen;
                case Category.Conditioner:
                    productIndex = ProductSearchSelection(StoredConditioner, wantedProductUsage, wantedProductSpecies);
                    ProductToOpen = StoredShampoo[productIndex];
                    StoredShampoo.RemoveAt(productIndex);
                    return ProductToOpen;
                case Category.Perfume:
                    productIndex = ProductSearchSelection(StoredPerfume, wantedProductUsage, wantedProductSpecies);
                    ProductToOpen = StoredShampoo[productIndex];
                    StoredShampoo.RemoveAt(productIndex);
                    return ProductToOpen;

                default:
                    break;
            }

            return ProductToOpen;
        }
        
        int ProductSearchSelection(List<Product> CategoryStock, Usage wantedProductUsage, Species wantedProductSpecies)
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
