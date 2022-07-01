using Stock.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain
{
    public static class DogShampooConsumption
    {
        public static int newCurrentVolume;
        public static int VolumeSpentOnService(Service currentService)
        {
            if (currentService.usage == Usage.Geral) //Shampoo Comum
            {
                if (currentService.breedSize == BreedSize.Grande)
                {
                    return 200;
                }

                else if (currentService.breedSize == BreedSize.Pequeno)
                {
                    return 100;
                }

                else
                {
                    return 0;
                }


            }
            else if (currentService.usage == Usage.Especial) //Shampoo Especial
            { 

                if (currentService.breedSize == BreedSize.Grande)
                {
                    return 150;
                }

                else if (currentService.breedSize == BreedSize.Pequeno)
                {
                    return 75;
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
