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
        static void consumptionRegistry(string[] args)
        {

            var dictDog = new Dictionary<(Category category, Usage usage, BreedSize size), int>();
            dictDog.Add((Category.Shampoo, Usage.General, BreedSize.Grande), 200);
            dictDog.Add((Category.Shampoo, Usage.General, BreedSize.Pequeno), 100);
            dictDog.Add((Category.Shampoo, Usage.Special, BreedSize.Grande), 150);
            dictDog.Add((Category.Shampoo, Usage.Special, BreedSize.Pequeno), 75);
            dictDog.Add((Category.Conditioner, Usage.General, BreedSize.Grande), 50);
            dictDog.Add((Category.Conditioner, Usage.General, BreedSize.Pequeno), 25);
            dictDog.Add((Category.Conditioner, Usage.Special, BreedSize.Grande), 20);
            dictDog.Add((Category.Conditioner, Usage.Special, BreedSize.Pequeno), 10);

            var dictCat = new Dictionary<(Category category, Usage usage), int>();
            dictCat.Add((Category.Shampoo, Usage.General), 50);
            dictCat.Add((Category.Shampoo, Usage.Special), 20);
            dictCat.Add((Category.Conditioner, Usage.General), 15);
            dictCat.Add((Category.Conditioner, Usage.Special), 10);

        }
    }
}
