using Stock.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain
{
    public static class CatShampooConsumption
    {
        public static int newCurrentVolume;
        public static int VolumeSpentOnService(Service currentService)
        {
            if (currentService.usage == Usage.Geral) //Shampoo Comum
            {
                return 50;
            }
            else if (currentService.usage == Usage.Especial) //Shampoo Especial
            {
                return 20;
            }
            else
            {
                return 0;
            }

        }
    }
}
