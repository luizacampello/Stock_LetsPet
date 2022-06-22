using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    internal class Stock
    {
        private List<Product> StoredShampoo = new();
        public List<Product> StoredConditioner = new();
        public List<Product> StoredPerfume = new();

        List<Product> GetFullStock()
        {
            List<Product> fullStock = StoredShampoo.Concat(StoredConditioner).Concat(StoredPerfume).ToList();
            return fullStock;
        }

        int TypeQuantity(Type productType)
        {
            switch (productType)
            {
                case Type.Shampoo:
                    return StoredShampoo.Count;
                case Type.Conditioner:
                    return StoredConditioner.Count;
                case Type.Perfume:
                    return StoredPerfume.Count;
                default:
                    break;
            }
            return 0;
        }

        void AddToStock(Product newProduct)
        {
            List<Product> storageSection = StorageSectionSelection(newProduct.type);
            storageSection.Add(newProduct);
            storageSection.Sort((x, y) => x.ExpirationDate.CompareTo(y.ExpirationDate));
        }

        Product RemoveFromStock(Type productType, Usage wantedProductUsage, Species wantedProductSpecies)
        {
            
        }

        int ProductSearchSelection(List<Product> typeStock, Usage wantedProductUsage, Species wantedProductSpecies)
        {
            int productIndex = -1;

            for (int i = 0; i < typeStock.Count; i++)
            {
                var product = typeStock[i];
                if (product.Usage == wantedProductUsage && product.Species == wantedProductSpecies)
                {
                    productIndex = i;
                    break;
                }
            }

            return productIndex;
        }

        List<Product> StorageSectionSelection(Type wantedproductType)
        {
            switch (wantedproductType)
            {
                case Type.Shampoo:
                    return StoredShampoo;
                case Type.Conditioner:
                    return StoredConditioner;
                case Type.Perfume:
                    return StoredShampoo;
                default:
                    return new();
            }
        }
    }
}
