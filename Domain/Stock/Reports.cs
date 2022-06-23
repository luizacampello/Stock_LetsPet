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

        void StockContentReport()
        {
            if (stock.ProductCategoryQuantity(Category.Shampoo) != 0)
            {
                Console.WriteLine("Lista de shampoos disponíveis:");
                foreach (Product shampoo in stock.StoredShampoo)
                {
                    Console.WriteLine(shampoo.Usage);
                }
            }
            else
                Console.WriteLine("Não existem shampoos no estoque.");

            if (stock.StoredConditioner.Count != 0)
            {
                Console.WriteLine("Lista de condicionadores disponíveis:");
                foreach (Product conditioner in stock.StoredConditioner)
                {

                }
            }
            else
                Console.WriteLine("Não existem condicionadores no estoque.");

            if (stock.StoredPerfume.Count != 0)
            {
                Console.WriteLine("Lista de perfumes disponíveis:");
                foreach (Product perfume in stock.StoredPerfume)
                {

                }
            }
            else
                Console.WriteLine("Não existem perfumes no estoque.");
        }

        void Search()
        {
            
        }

        void PrintProduct()
        {

        }
    }
}
