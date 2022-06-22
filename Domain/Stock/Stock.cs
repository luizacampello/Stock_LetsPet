﻿using Stock.Domain.Common;
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

        public int TypeQuantity(Type productType)
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
            switch (newProduct.Type)
            {
                case Type.Shampoo:
                    StoredShampoo.Add(newProduct);
                    StoredShampoo.Sort((x, y) => x.ExpirationDate.CompareTo(y.ExpirationDate));
                    return;
                case Type.Conditioner:
                    StoredConditioner.Add(newProduct);
                    StoredConditioner.Sort((x, y) => x.ExpirationDate.CompareTo(y.ExpirationDate));
                    return;
                case Type.Perfume:
                    StoredPerfume.Add(newProduct);
                    StoredPerfume.Sort((x, y) => x.ExpirationDate.CompareTo(y.ExpirationDate));
                    return;
                default:
                    break;
            }
        }

        Product RemoveFromStock(Type productType, Usage wantedProductUsage, Species wantedProductSpecies)
        {
            int 
            switch (productType)
            {
                case Type.Shampoo:
                    int productIndex = ProductSearchSelection(StoredShampoo, wantedProductUsage, wantedProductSpecies);
                    Product ProductToOpen = StoredShampoo[productIndex];
                    StoredShampoo.RemoveAt(productIndex);
                    return ProductToOpen;
                case Type.Conditioner:
                    int productIndex = ProductSearchSelection(StoredConditioner, wantedProductUsage, wantedProductSpecies);
                    Product ProductToOpen = StoredShampoo[productIndex];
                    StoredShampoo.RemoveAt(productIndex);
                    return ProductToOpen;
                case Type.Perfume:
                    int productIndex = ProductSearchSelection(StoredPerfume, wantedProductUsage, wantedProductSpecies);
                    Product ProductToOpen = StoredShampoo[productIndex];
                    StoredShampoo.RemoveAt(productIndex);
                    return ProductToOpen;

                default:
                    break;
            }
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


    }
}