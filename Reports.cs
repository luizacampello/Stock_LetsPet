using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public class Reports
    {
        public List<Product> StoredShampoo = new();
        public List<Product> StoredConditioner = new();
        public List<Product> StoredPerfume = new();

        void StockContentReport()
        {
            if (StoredShampoo.Count != 0)
            {
                Console.WriteLine("Lista de shampoos disponíveis:");
                foreach (Product shampoo in StoredShampoo)
                {
                    Console.WriteLine(shampoo.Usage);
                }
            }
            else
                Console.WriteLine("Não existem shampoos no estoque.");

            if (StoredConditioner.Count != 0)
            {
                Console.WriteLine("Lista de condicionadores disponíveis:");
                foreach (Product conditioner in StoredConditioner)
                {

                }
            }
            else
                Console.WriteLine("Não existem condicionadores no estoque.");

            if (StoredPerfume.Count != 0)
            {
                Console.WriteLine("Lista de perfumes disponíveis:");
                foreach (Product perfume in StoredPerfume)
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
