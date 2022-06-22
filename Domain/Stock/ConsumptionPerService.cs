using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Domain.Common;

namespace Stock.Domain.Stock
{
    public class ConsumptionPerService
    {
        static void Main(string[] args)
        {

            var dictDog = new Dictionary<(string Type, string isForSpecialServices, string size), int>();
            dictDog.Add(("Shampoo", "comum", "grande"), 200);
            dictDog.Add(("Shampoo", "comum", "pequeno"), 100);
            dictDog.Add(("Sham poo", "especial", "grande"), 150);
            dictDog.Add(("Shampoo", "especial", "pequeno"), 75);
            dictDog.Add(("Conditioner", "comum", "grande"), 50);
            dictDog.Add(("Conditioner", "comum", "pequeno"), 25);
            dictDog.Add(("Conditioner", "especial", "grande"), 20);
            dictDog.Add(("Conditioner", "especial", "pequeno"), 10);

            var dictCat = new Dictionary<(Type type, Usage usage), int>();
            dictCat.Add((Type.Shampoo, Usage.General), 50);
            dictCat.Add((Type.Shampoo, Usage.Special), 20);
            dictCat.Add((Type.Conditioner, Usage.General), 15);

        }
    }
}
