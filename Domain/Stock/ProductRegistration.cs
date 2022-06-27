using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Stock
{
    public class ProductRegistration
    {
        Product newProduct = new Product();
        private int minAmount = 2;
        private int maxAmount = 20;

        public void NewProductRegistry()
        {
            Product newProduct = new();
            newProduct.Category = SelectCategory();
            newProduct.Usage = SelectUsage();
            newProduct.Name = InputName();
            newProduct.Brand = InputBrand();
            newProduct.Price = InputPrice();
            newProduct.TotalVolume = InputTotalVolume();
            newProduct.CurrentVolume = newProduct.TotalVolume;
            newProduct.ExpirationDate = InputExpirationDate();
            newProduct.Species = SelectSpecie();
        }

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

                    Console.WriteLine(Messages.formatError);
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

                    Console.WriteLine(Messages.formatError);
                    return SelectUsage();

            }

        }

        public string InputName()
        {
            Console.WriteLine(Messages.inputName);
            var InptName = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(InptName))
            {
                Console.WriteLine(Messages.formatError);
                return InputName();
            }
            else
                return InptName;
        }

        public string InputBrand()
        {
            Console.WriteLine(Messages.inputBrand);
            var InptBrand = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(InptBrand))
            {
                Console.WriteLine(Messages.formatError);
                return InputBrand();
            }
            else
                return InptBrand;
        }

        public decimal InputPrice()
        {
            Console.WriteLine(Messages.inputPrice);
            var InPrice = Console.ReadLine();
            var correctPrice = decimal.TryParse(InPrice, out var InptPrice);
            if (correctPrice && InptPrice > 0)
            {
                return InptPrice;
            }
            else
            {
                Console.WriteLine(Messages.formatError);
                return InputPrice();
            }
        }

        public int InputTotalVolume()
        {
            Console.WriteLine(Messages.inputTotalVolume);
            var InTotalVolume = Console.ReadLine();
            var correctTotalVolume = int.TryParse(InTotalVolume, out var InptTotalVolume);
            if (correctTotalVolume && InptTotalVolume > 0)
            {
                return InptTotalVolume;
            }
            else
            {
                Console.WriteLine(Messages.formatError);
                return InputTotalVolume();
            }
        }

        public DateTime InputExpirationDate()
        {
            Console.WriteLine(Messages.inputExpirationDate);
            var InDate = Console.ReadLine();
            var correctDate = DateTime.TryParse(InDate, out var InptExpirationDate);
            if (correctDate && InptExpirationDate > DateTime.Now)
            {
                return InptExpirationDate;
            }
            else
            {
                Console.WriteLine(Messages.formatError);
                return InputExpirationDate();
            }
        }


        public Common.Species SelectSpecie()
        {
            Console.WriteLine(Messages.SpecieSelectionMenu);
            var inputSpecie = Console.ReadLine();
            switch (inputSpecie)
            {
                case "1":
                    return Common.Species.Cachorro;


                case "2":
                    return Common.Species.Gato;


                default:

                    Console.WriteLine(Messages.formatError);
                    return SelectSpecie();

            }

        }
    }

}

