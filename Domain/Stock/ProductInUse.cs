using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Stock
{
    public class ProductInUse
    {
        public List<Product> OpenShampoo { get; private set;  } = new();
        public List<Product> OpenConditioner { get; private set; } = new();
        public List<Product> OpenPerfume { get; private set;  } = new();

        




        /*int amountproduct = 0;
        var service = new Tuple<string,string,string> ();

        
        public int getConsumptionPerService()
        {
             return amountproduct;
        }

        //// colocar no metodo UseProductType

        public void ShampooUse()
        {
            if (OpenShampoo.Contains (Shampoo))
            {
                if(shampoo.CurrentVolume >= amountproduct) 
                {
                    return Console.WriteLine("Produto aberto!E tem quantidade suficiente");
                   shampoo.CurrentVolume = CurrentVolume - amountproduct;
                }
                else (shampoo.CurrentVolume < amountproduct)
                {
                    return Console.WriteLine("Produto aberto!Mas sem quantidade suficiente para banho");
                    Console.WriteLine("Abrir novo produto");
                    // metodo abrir novo shampoo = remover do estoque
                    shampoo.CurrentVolume = TotalVolume - amountproduct + shampoo.CurrentVolume;
                    OpenShampoo.Add(shampoo);
                }
            }
            else
            {
                Console.WriteLine("Abrir novo produto");
                // metodo abrir novo shampoo
                OpenShampoo.Add(shampoo);
                shampoo.CurrentVolume = TotalVolume - amountproduct;
            }

        }

        public void ConditionerUse()
        {
            if (OpenConditioner.Contains(conditioner))
            {
                if (conditioner.CurrentVolume >= amountproduct)
                {
                    return Console.WriteLine("Produto aberto!E tem quantidade suficiente");
                    conditioner.CurrentVolume = CurrentVolume - amountproduct;
                }
                else (conditioner.CurrentVolume < amountproduct)
                {
                    return Console.WriteLine("Produto aberto!Mas sem quantidade suficiente para banho");
                    Console.WriteLine("Abrir novo produto");
                    // metodo abrir novo cond
                    conditioner.CurrentVolume = TotalVolume - amountproduct + conditioner.CurrentVolume;
                    OpenConditioner.Add(conditioner);
                }
            }
            else
            {
                Console.WriteLine("Abrir novo produto");
                // metodo abrir novo cond 
                OpenConditioner.Add(conditioner);
                conditioner.CurrentVolume = TotalVolume - amountproduct;
            }

        }

        public void PerfumeUse()
        {
            if (OpenPerfume.Contains(perfume))
            {
                if (perfume.CurrentVolume >= amountproduct)
                {
                    return Console.WriteLine("Produto aberto!E tem quantidade suficiente");
                    perfume.CurrentVolume = CurrentVolume - amountproduct;
                }
                else (perfume.CurrentVolume < amountproduct)
                {
                    return Console.WriteLine("Produto aberto!Mas sem quantidade suficiente para banho");
                    Console.WriteLine("Abrir novo produto");
                    // metodo abrir novo perfume
                    perfume.CurrentVolume = TotalVolume - amountproduct + perfume.CurrentVolume;
                    OpenPerfume.Add(perfume);
                }
            }
            else
            {
                Console.WriteLine("Abrir novo produto");
               // metodo abrir novo perfume
                OpenPerfume.Add(perfume);
                perfume.CurrentVolume = TotalVolume - amountproduct;
            }
        }*/

       


    }
}
