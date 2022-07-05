using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Domain.Common;
using Stock.Domain;

namespace Stock.Domain
{
    public static class ConsumptionPerService
    {
        private static void consumptionRegistry()
        {
            var dictDog = new Dictionary<(Category category, Usage usage, BreedSize size), int>();
            dictDog.Add((Category.Shampoo, Usage.General, BreedSize.Big), 200);
            dictDog.Add((Category.Shampoo, Usage.General, BreedSize.Small), 100);
            dictDog.Add((Category.Shampoo, Usage.Special, BreedSize.Big), 150);
            dictDog.Add((Category.Shampoo, Usage.Special, BreedSize.Small), 75);
            dictDog.Add((Category.Conditioner, Usage.General, BreedSize.Big), 50);
            dictDog.Add((Category.Conditioner, Usage.General, BreedSize.Small), 25);
            dictDog.Add((Category.Conditioner, Usage.Special, BreedSize.Big), 20);
            dictDog.Add((Category.Conditioner, Usage.Special, BreedSize.Small), 10);

            var dictCat = new Dictionary<(Category category, Usage usage), int>();
            dictCat.Add((Category.Shampoo, Usage.General), 50);
            dictCat.Add((Category.Shampoo, Usage.Special), 20);
            dictCat.Add((Category.Conditioner, Usage.General), 15);
            dictCat.Add((Category.Conditioner, Usage.Special), 10);

        }
    }
}
