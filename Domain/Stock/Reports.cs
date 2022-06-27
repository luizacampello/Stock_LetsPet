﻿using Stock.Domain.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Stock
{
    public class Reports
    {
        private Stock stock;

        public Reports(Stock stock)
        {
            this.stock = stock;
        }

        void StockContentReport()
        {
            if (stock.ProductCategoryQuantity(Category.Shampoo) != 0)
            {
                Console.WriteLine("Lista de shampoos disponíveis:");
                foreach (Product shampoo in stock.StoredShampoo)
                    PrintProduct(shampoo);
            }
            else
                Console.WriteLine("Não existem shampoos no estoque.");

            if (stock.StoredConditioner.Count != 0)
            {
                Console.WriteLine("Lista de condicionadores disponíveis:");
                foreach (Product conditioner in stock.StoredConditioner)
                    PrintProduct(conditioner);
            }
            else
                Console.WriteLine("Não existem condicionadores no estoque.");

            if (stock.StoredPerfume.Count != 0)
            {
                Console.WriteLine("Lista de perfumes disponíveis:");
                foreach (Product perfume in stock.StoredPerfume)
                    PrintProduct(perfume);
            }
            else
                Console.WriteLine("Não existem perfumes no estoque.");
        }

        void ProductCostByServiceReport()
        {
            //Parte extra (não necessária no momento).
        }

        public void SearchResultsByType(List<Product> products)
        {
            foreach (Product p in products)
                PrintProduct(p);
        }

        public void SearchResultsByName()
        {

        }
        public void SearchResultsByBrand()
        {

        }

        public void ShowFullStock()
        {
            //List<Product> fullStock = stock.GetFullStock();
            foreach (Product product in stock.GetFullStock())
                PrintProduct(product);
        }

        public void Search(int caso)
        {
            List<Product> fullStock = stock.GetFullStock();
            switch (caso)
            {
                case 0:
                    foreach (Product product in fullStock)
                        PrintProduct(product);
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        static void PrintProduct(Product product)
        {
            Console.WriteLine(@$"Nome: {product.Name}
Categoria: {product.Category}
Espécie: {product.Species}
Uso: {product.Usage}
Marca: {product.Brand}
Preço: {product.Price}
Volume total: {product.TotalVolume}
Volume restante: {product.CurrentVolume}
Data de validade: {product.ExpirationDate}
");
        }
    }
}
