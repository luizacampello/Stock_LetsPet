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
            dictDog.Add((Category.Shampoo, Usage.Geral, BreedSize.Grande), 200);
            dictDog.Add((Category.Shampoo, Usage.Geral, BreedSize.Pequeno), 100);
            dictDog.Add((Category.Shampoo, Usage.Especial, BreedSize.Grande), 150);
            dictDog.Add((Category.Shampoo, Usage.Especial, BreedSize.Pequeno), 75);
            dictDog.Add((Category.Conditioner, Usage.Geral, BreedSize.Grande), 50);
            dictDog.Add((Category.Conditioner, Usage.Geral, BreedSize.Pequeno), 25);
            dictDog.Add((Category.Conditioner, Usage.Especial, BreedSize.Grande), 20);
            dictDog.Add((Category.Conditioner, Usage.Especial, BreedSize.Pequeno), 10);

            var dictCat = new Dictionary<(Category category, Usage usage), int>();
            dictCat.Add((Category.Shampoo, Usage.Geral), 50);
            dictCat.Add((Category.Shampoo, Usage.Especial), 20);
            dictCat.Add((Category.Conditioner, Usage.Geral), 15);
            dictCat.Add((Category.Conditioner, Usage.Especial), 10);

        }
    }
}
