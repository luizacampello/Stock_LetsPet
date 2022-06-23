using Stock.Domain.Common;
using System;
using System.Collections.Generic;
using Stock.Domain.Common;

namespace Stock.Domain.Stock
{
    public class Product
    {

        public Category Category { get; set; }
        public Usage Usage { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int TotalVolume { get; set; }
        public int CurrentVolume { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Species Species { get; set; }


        public Category SelectCategory()
        {
            Console.WriteLine(Messages.CategorySelectionMenu);
            var inputType = Console.ReadLine();
            switch (inputType)
            {
                case "1":
                    return Category.Shampoo;

                case "2":
                    return Category.Conditioner;

                case "3":
                    return Category.Perfume;

                default:

                    Console.WriteLine(Messages.inputError);
                    return SelectCategory();

            }

        }

        public Usage SelectUsage()
        {
            Console.WriteLine(Messages.UsageSelectionMenu);
            var inputUsage = Console.ReadLine();
            switch (inputUsage)
            {
                case "1":
                    return Usage.General;


                case "2":
                    return Usage.Special;


                default:

                    Console.WriteLine(Messages.inputError);
                    return SelectUsage();

            }

        }

        public string InputName()
        {
            Console.WriteLine("Qual o nome do produto?");
            var InptName = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(InptName))
            {
                Console.WriteLine("Não é possível cadastrar um produto sem o nome, tente novamente");
                return InputName();
            }
            else
                return InptName;
        }

        public string InputBrand()
        {
            Console.WriteLine("Qual a marca do produto?");
            var InptBrand = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(InptBrand))
            {
                Console.WriteLine("Não é possível cadastrar um produto sem a marca, tente novamente");
                return InputBrand();
            }
            else
                return InptBrand;
        }

        public decimal InputPrice()
        {
            Console.WriteLine("Qual o preço do produto?");
            var InPrice = Console.ReadLine();
            var correctPrice = decimal.TryParse(InPrice, out var InptPrice);
            if (correctPrice && InptPrice > 0)
            {
                return InptPrice;
            }
            else
            {
                Console.WriteLine("Informação incorreta, tente informar o preço novamente");
                return InputPrice();
            }
        }

        public int InputTotalVolume()
        {
            Console.WriteLine("Quantos ml o produto possúi?");
            var InTotalVolume = Console.ReadLine();
            var correctTotalVolume = int.TryParse(InTotalVolume, out var InptTotalVolume);
            if (correctTotalVolume && InptTotalVolume > 0)
            {
                return InptTotalVolume;
            }
            else
            {
                Console.WriteLine("Informação incorreta, tente informar o volume novamente");
                return InputTotalVolume();
            }
        }

        public DateTime InputExpirationDate()
        {
            Console.WriteLine("Qual a data de validade do produto?");
            var InDate = Console.ReadLine();
            var correctDate = DateTime.TryParse(InDate, out var InptExpirationDate);
            if (correctDate && InptExpirationDate > DateTime.Now)
            {
                return InptExpirationDate;
            }
            else
            {
                Console.WriteLine("Data invalída ou produto vencido, tente novamente");
                return InputExpirationDate();
            }
        }


        public Species SelectSpecie()
        {
            Console.WriteLine("Para qual tipo de espécie o produto é indicado: Digite:\n1 para Cachorro\n2 para Gato");
            var inputSpecie = Console.ReadLine();
            switch (inputSpecie)
            {
                case "1":
                    return Species.Cachorro;


                case "2":
                    return Species.Gato;


                default:

                    Console.WriteLine(Messages.inputError);
                    return SelectSpecie();

            }

        }
    }

}
