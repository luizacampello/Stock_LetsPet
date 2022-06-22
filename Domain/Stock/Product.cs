using Stock.Domain.Common;
using System;
using System.Collections.Generic;
using Stock.Domain.Common;

namespace Stock.Domain.Stock
{
    public class Product
    {

        public Type Type { get; set; }       
        public Usage Usage { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int TotalVolume { get; set; }
        public int CurrentVolume { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Species Species { get; set; }


        public Type SelectUsage()
        {
            Console.WriteLine("Qual o tipo de uso do produto: Digite:\n1 para Comum\n2 para Especial");
            var inputUsage = Console.ReadLine();
            switch (inputUsage)
            {
                case "1":
                    return Usage.;


                case "2":
                    return Type.Conditioner;

               
                default:

                    Console.WriteLine("Entrada invalida, tente novamente");
                    SelectUsage();
                    break;
            }
            return Type.Shampoo;
        }

    }


}
