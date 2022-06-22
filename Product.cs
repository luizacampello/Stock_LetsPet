using System;
using System.Collections.Generic;

namespace Stock
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

        public Type SelectType()
        {
            Console.WriteLine("Qual o tipo de produto: Digite:\n1 para Shampoo\n2 para Condicionador\n3 para Perfume");
            var inputType = Console.ReadLine();
            switch (inputType)
            {
                case "1":
                    Type = Type.Shampoo;

                    break;
                case "2":
                    Type = Type.Conditioner;

                    break;
                case "3":
                    Type = Type.Perfume;

                    break;
                default:

                    Console.WriteLine("Entrada invalida, tente novamente");
                    SelectType();
                    break;
            }
             return Type;
        }
    }


}
