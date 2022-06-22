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

            var dictDog = new Dictionary<(Type type, Usage usage, BreedSize breedSize), int>();
            dictDog.Add((Type.Shampoo, Usage.General, BreedSize.Grande), 200);
            dictDog.Add((Type.Shampoo, Usage.General, BreedSize.Pequeno), 100);
            dictDog.Add((Type.Shampoo, Usage.Special, BreedSize.Grande), 150);
            dictDog.Add((Type.Shampoo, Usage.Special, BreedSize.Pequeno), 75);
            dictDog.Add((Type.Conditioner, Usage.General, BreedSize.Grande), 50);
            dictDog.Add((Type.Conditioner, Usage.General, BreedSize.Pequeno), 25);
            dictDog.Add((Type.Conditioner, Usage.Special, BreedSize.Grande), 20);
            dictDog.Add((Type.Conditioner, Usage.Special, BreedSize.Pequeno), 10);

            var dictCat = new Dictionary<(Type type, Usage usage), int>();
            dictCat.Add((Type.Shampoo, Usage.General), 50);
            dictCat.Add((Type.Shampoo, Usage.Special), 20);
            dictCat.Add((Type.Conditioner, Usage.General), 15);

        }
    }
}
