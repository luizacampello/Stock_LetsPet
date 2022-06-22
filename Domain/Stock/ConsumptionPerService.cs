using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Stock
{
    public class ConsumptionPerService
    {
        static void Main(string[] args)
        {

            var dictDog = new Dictionary<(string Type, string isForSpecialServices, string size), int>();
            dictDog.Add(("Shampoo", "comum", "grande"), 200);
            dictDog.Add(("Shampoo", "comum", "pequeno"), 100);
            dictDog.Add(("Shampoo", "especial", "grande"), 150);
            dictDog.Add(("Shampoo", "especial", "pequeno"), 75);
            dictDog.Add(("Conditioner", "comum", "grande"), 50);
            dictDog.Add(("Conditioner", "comum", "pequeno"), 25);
            dictDog.Add(("Conditioner", "especial", "grande"), 20);
            dictDog.Add(("Conditioner", "especial", "pequeno"), 10);

            var dictCat = new Dictionary<(string Type, string isForSpecialServices), int>();
            dictCat.Add(("shampoo", "comum"), 50);
            dictCat.Add(("shampoo", "especial"), 20);
            dictCat.Add(("Conditioner", "comum"), 15);
            dictCat.Add(("Conditioner", "especial"), 10);


            Console.WriteLine("=============Cachorro ==============");
            foreach (KeyValuePair<(string, string, string), int> item in dictDog)
            {
                Console.WriteLine("chave: {0}, valor: {1}", item.Key, item.Value);
            }
            Console.WriteLine();

            Console.WriteLine("=============Gato ==============");
            foreach (KeyValuePair<(string, string), int> item in dictCat)
            {
                Console.WriteLine("chave: {0}, valor: {1}", item.Key, item.Value);
            }
            Console.WriteLine();
        }
    }
}
