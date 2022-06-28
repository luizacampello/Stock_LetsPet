using Stock.Domain.Stock;
using Stock.Domain.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Services
{
    public static class InputServices
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
        
        public static string UserInputMainMenu()
        {
            List<string> options = new List<string>() { "1", "2", "3"};
            string userInput = "1";
            do
            {
                if (String.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine(Messages.invalidNullInput);
                }
                if (!options.Contains(userInput))
                {
                    Console.WriteLine(Messages.formatError);
                }
                Console.WriteLine(Messages.MenuMainMenu);
                string userInput = Console.ReadLine();   
            }
            while ((!String.IsNullOrWhiteSpace(userInput)) || (!options.Contains(userInput)));
            return userInput;
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

        public static Stock.Domain.Stock.Stock CreatedStock()
        { 
            Product InicialShampoo = new Product(Category.Shampoo,Usage.General,"Pet Clean 5 em 1",
                "Pet Clean", 14, 700,DateTime.Now.AddYears(1), Species.Cachorro);   
            Product InicialConditioner = new Product(Category.Conditioner,Usage.Geral, "Sanol Dog revitalizante",
                "Sanol", 17, 500,DateTime.Now.AddYears(1), Species.Cachorro);
            Product InicialPerfume = new Product (Category.Perfume, Usage.General, "Colônia Me.Au Pet Cheirinho de Bebê",
                "Me.Au Pet", 13, 120, DateTime.Now.AddYears(1), Species.Cachorro);
            
            Stock.Domain.Stock.Stock estoque = new Stock.Domain.Stock.Stock();
            estoque.AddToStock(InicialShampoo);
            estoque.AddToStock (InicialConditioner);
            estoque.AddToStock(InicialPerfume);
            return estoque;
        }


        public static void DefaultMenuStock()
        {
            Stock.Domain.Stock.Stock estoque = InputValidationAndFormat.CreatedStock();
            Reports relatorio = new Reports(estoque);
            ReportMenu relatorioMenu = new ReportMenu();
            //relatorioMenu. // precisa criar um construtor que aceite as duas propriedades
            string inputType = UserInput();
            switch (inputType)
            {
                case "1":
                    estoque.AddToStock(ProductRegistration.NewProductRegistry()); 
                    return;
                case "2":
                    //relatorio.MenuDeSelecao();
                    return;
                case "3":
                    //Main();
                    return;
                default:
                    Console.WriteLine(Messages.formatError);
                    DefaultMenuStock();
                    return;
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
            Console.Write(Messages.inputName);
            var InptName = UserInput();
            return InptName;
        }

        public static string NewBrand()
        {
            Console.Write(Messages.inputBrand);
            var InptBrand = UserInput();
            return InptBrand;
        }

        public static decimal NewPrice()
        {
            Console.Write(Messages.inputPrice);
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
            Console.Write(Messages.inputTotalVolume);
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
            Console.Write(Messages.inputExpirationDate);
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

        public static int NewQuantity()
        {
            
            Console.Write($"{Messages.inputQuantity} - 2");
            var InQuantity = UserInput();
            var correctQuantity = int.TryParse(InQuantity, out var InptQuantity);
            if (correctQuantity)
            {
                if (InptQuantity >= 1 && InptQuantity <= 20)
                {
                    return InptQuantity;
                }
                else
                {
                    Console.WriteLine();
                    return NewTotalVolume();
                }
            }
            else
            {
                Console.WriteLine(Messages.formatError);
                return NewTotalVolume();
            }
        }

    }


}
