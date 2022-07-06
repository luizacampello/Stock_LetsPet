using Stock.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain
{
    public static class CatConditionerConsumption
    {
        public static int newCurrentVolume;
        public static int VolumeSpentOnService(Service currentService)
        {
            if (currentService.usage == Usage.General) //Condicionador Comum
            {
                return 15;
            }
            else if (currentService.usage == Usage.Special) //Condicionador Especial
            {
                return 10;
            }
            else
            {
                return 0;
            }

        }
    }
}
