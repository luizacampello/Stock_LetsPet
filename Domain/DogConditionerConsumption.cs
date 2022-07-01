using Stock.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain
{
    public static class DogConditionerConsumption
    {
        public static int newCurrentVolume;
        public static int VolumeSpentOnService(Service currentService)
        {
            if (currentService.usage == Usage.Geral) //Condicionador Comum
            {
                if (currentService.breedSize == BreedSize.Grande)
                {
                    return 50;
                }

                else if (currentService.breedSize == BreedSize.Pequeno)
                {
                    return 25;
                }

                else
                {
                    return 0;
                }
            }
            else if (currentService.usage == Usage.Especial) //Condicionador Especial
            {

                if (currentService.breedSize == BreedSize.Grande)
                {
                    return 20;
                }

                else if (currentService.breedSize == BreedSize.Pequeno)
                {
                    return 10;
                }

                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

        }
    }
}
