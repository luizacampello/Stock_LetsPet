using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Stock
{
    public class ProductInUse
    {
        public List<Product> OpenShampoo = new();
        public List<Product> OpenConditioner = new();
        public List<Product> OpenPerfume = new();
        
        string specie;
        int amountproduct = 0;
        var service = new Tuple<string,string,string> ();

        public void FindIn()
        {
            if (specie == "dog")
            {
                amountproduct = dictDog[service];
            }
            else if (specie == "cat")
            {
                amountproduct = dictCat[service];
            }
        }
        
        public int getConsumptionPerService()
        {
             return amountproduct;
        }


        public void Usage()
        {
            if (shampoo.usage == "usage")
            {
                if(shampoo.CurrentVolume > amountproduct)
                {
                    return Console.WriteLine("Tem quantidade suficiente");
                }
            }
        }
        
        Product.usage 





        

        












    }
}
