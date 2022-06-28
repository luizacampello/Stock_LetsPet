using Stock.Domain.Stock;
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

        public void StockContentReport()
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
            //Parte bônus (não necessária no momento).
        }

        public void SearchResultsByType(List<Product> products)
        {
            foreach (Product p in products)
                PrintProduct(p);
        }

        public void SearchResultsByName(string nameInput)
        {
            bool found = false;
            foreach (Product product in stock.GetFullStock())
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
            foreach (Product product in stock.GetFullStock())
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
            foreach (Product product in stock.GetFullStock())
                PrintProduct(product);
        }

        /*public void Search(int caso)
        {
            List<Product> fullStock = stock.GetFullStock();
        }
        */

        public static void PrintProduct(Product product)
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
