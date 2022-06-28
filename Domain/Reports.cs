﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain
{
    public class Reports
    {
        private Stock storage;
        public Reports(Stock storage)
        {
            this.storage = storage;
        }
        public void StockContentReport()
        {
            if (storage.ProductCategoryQuantity(Category.Shampoo) != 0)
            {
                Console.WriteLine("Lista de shampoos disponíveis:");
                foreach (Product shampoo in storage.StoredShampoo)
                    PrintProduct(shampoo);
            }
            else
                Console.WriteLine("Não existem shampoos no estoque.");

            if (storage.StoredConditioner.Count != 0)
            {
                Console.WriteLine("Lista de condicionadores disponíveis:");
                foreach (Product conditioner in storage.StoredConditioner)
                    PrintProduct(conditioner);
            }
            else
                Console.WriteLine("Não existem condicionadores no estoque.");

            if (storage.StoredPerfume.Count != 0)
            {
                Console.WriteLine("Lista de perfumes disponíveis:");
                foreach (Product perfume in storage.StoredPerfume)
                    PrintProduct(perfume);
            }
            else
                Console.WriteLine("Não existem perfumes no estoque.");
        }

        public void SearchResultsByType(List<Product> products)
        {
            foreach (Product p in products)
                PrintProduct(p);
        }

        public void SearchResultsByName(string nameInput)
        {
            bool found = false;
            foreach (Product product in storage.GetFullStock())
            {
                if (product.Name == nameInput)
                {
                    PrintProduct(product);
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine(Messages.NoResults);
        }

        public void SearchResultsByBrand(string brandInput)
        {
            bool found = false;
            foreach (Product product in storage.GetFullStock())
            {
                if (product.Brand == brandInput)
                {
                    PrintProduct(product);
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine(Messages.NoResults);
        }

        public void ShowFullStock()
        {
            foreach (Product product in storage.GetFullStock())
                PrintProduct(product);
        }

        public void PrintProduct(Product product)
        {
            Console.WriteLine(@$"Nome: {product.Name}
Categoria: {product.Category}
Espécie: {product.Species}
Uso: {product.Usage}
Marca: {product.Brand}
Preço: {product.Price}
Volume total: {product.TotalVolume}
Volume restante: {product.CurrentVolume}
Data de validade: {product.ExpirationDate.Date}
");
        }

    }
}
