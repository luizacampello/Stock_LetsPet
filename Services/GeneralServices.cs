using Stock.Domain.Stock;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Services
{
    public static class InputValidationAndFormat
    {
        private static string DefaultTextFormat(string userInput)
        {
            return CapitalizeLettersAfterSpace(userInput).Trim();
        }

        private static string CapitalizeLettersAfterSpace(string text)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(text);
        }

        public static string UserInput()
        {
            string userInput = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(userInput))
            {
                return DefaultTextFormat(userInput);
            }
            Console.WriteLine(Messages.invalidNullInput);
            return UserInput();
        }

        public static Category SelectCategory()
        {
            Console.WriteLine(Messages.CategorySelectionMenu);
            var inputType = UserInput();
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

        public static Usage SelectUsage()
        {
            Console.WriteLine(Messages.UsageSelectionMenu);
            var inputUsage = UserInput();
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

        public static string NewName()
        {
            Console.WriteLine(Messages.inputName);
            var InptName = UserInput();
            return InptName;
        }

        public static string NewBrand()
        {
            Console.WriteLine(Messages.inputBrand);
            var InptBrand = UserInput();
            return InptBrand;
        }

        public static decimal NewPrice()
        {
            Console.WriteLine(Messages.inputPrice);
            var InPrice = UserInput();
            var correctPrice = decimal.TryParse(InPrice, out var InptPrice);
            if (correctPrice && InptPrice > 0)
            {
                return InptPrice;
            }
            else
            {
                Console.WriteLine(Messages.formatError);
                return NewPrice();
            }
        }

        public static int NewTotalVolume()
        {
            Console.WriteLine(Messages.inputTotalVolume);
            var InTotalVolume = UserInput();
            var correctTotalVolume = int.TryParse(InTotalVolume, out var InptTotalVolume);
            if (correctTotalVolume && InptTotalVolume > 0)
            {
                return InptTotalVolume;
            }
            else
            {
                Console.WriteLine(Messages.formatError);
                return NewTotalVolume();
            }
        }

        public static DateTime NewExpirationDate()
        {
            Console.WriteLine(Messages.inputExpirationDate);
            var InDate = UserInput();
            var correctDate = DateTime.TryParse(InDate, out var InptExpirationDate);
            if (correctDate && InptExpirationDate > DateTime.Now)
            {
                return InptExpirationDate;
            }
            else
            {
                Console.WriteLine(Messages.formatError);
                return NewExpirationDate();
            }
        }

        public static Domain.Common.Species SelectSpecies()
        {
            Console.WriteLine(Messages.SpecieSelectionMenu);
            var inputSpecie = UserInput();
            switch (inputSpecie)
            {
                case "1":
                    return Domain.Common.Species.Cachorro;


                case "2":
                    return Domain.Common.Species.Gato;


                default:

                    Console.WriteLine(Messages.formatError);
                    return SelectSpecies();

            }

        }


    }


}
