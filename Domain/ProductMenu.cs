using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Domain.Common;

namespace Stock.Domain
{
    public static class ProductMenu
    {
        public static void BeginProgram()
        {
            Stock petStock = new();
            MenuSelection(petStock);
        }

        private static void NewProductTest(Stock petStock)
        {
            Product newProduct = ProductRegistration.NewProductPropertiesRegistry();
            ProductRegistration.AddNewProductToStock(newProduct, petStock);
        }

        private static void MenuSelection(Stock petStock)
        {
            Console.WriteLine(Messages.MenuProductTest);
            string userInput = InputServices.UserInput();
            switch (userInput)
            {
                case "1":
                    NewProductTest(petStock);
                    ReturnProgram(petStock);
                    return;
                case "2":
                    PrintStock(petStock);
                    ReturnProgram(petStock);
                    return;
                case "3":
                    OpenProduct(petStock);
                    ReturnProgram(petStock);
                    return;
                default:
                    Console.WriteLine(Messages.formatError);
                    MenuSelection(petStock);
                    return;
            }
        }

        private static void OpenProduct(Stock petStock)
        {
            Category wantedProductType = InputServices.SelectCategory();
            Usage wantedProductUsage = InputServices.SelectUsage();
            Species wantedProductSpecies = InputServices.SelectSpecies();
            Product removedProduct = Stock.RemoveFromStock(petStock, wantedProductType, wantedProductUsage, wantedProductSpecies);
            Reports.PrintProduct(removedProduct);
        }

        private static void PrintStock(Stock petStock)
        {
            List<Product> stockCollection = petStock.GetFullStock();

            foreach (Product item in stockCollection)
            {
                Reports.PrintProduct(item);
            }
        }

        private static void ReturnProgram(Stock petStock)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(Messages.returnEntryKey);
            Console.ReadKey();
            MenuSelection(petStock);
            return;
        }

        public static Stock CreatedStock()
        {
            Product InicialShampoo = new Product(Category.Shampoo, Usage.Geral, "Pet Clean 5 em 1",
                "Pet Clean", 14, 700, DateTime.Now.AddYears(1), Species.Cachorro);
            Product InicialConditioner = new Product(Category.Conditioner, Usage.Geral, "Sanol Dog revitalizante",
                "Sanol", 17, 500, DateTime.Now.AddYears(1), Species.Cachorro);
            Product InicialPerfume = new Product(Category.Perfume, Usage.Geral, "Colônia Me.Au Pet Cheirinho de Bebê",
                "Me.Au Pet", 13, 120, DateTime.Now.AddYears(1), Species.Cachorro);

            Stock estoque = new Stock();
            estoque.AddToStock(InicialShampoo);
            estoque.AddToStock(InicialConditioner);
            estoque.AddToStock(InicialPerfume);
            return estoque;
        }

        public static void DefaultMenuStock()
        {
            Stock storage = CreatedStock();
            string inputType = InputServices.UserInput();
            switch (inputType)
            {
                case "1":
                    storage.AddToStock(ProductRegistration.NewProductPropertiesRegistry());
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

        public static void ReportBrandMenu(string input, Stock storage)
        {
            Console.WriteLine(Messages.ReportBrandMenu);
            InputServices.UserInput();
            Reports.SearchResultsByBrand(input, storage);
        }

        public static void ReportNameMenu(string input, Stock storage)
        {
            Console.WriteLine(Messages.ReportNameMenu);
            InputServices.UserInput();
            Reports.SearchResultsByName(input, storage);
        }

        public static void ReportTypeMenu(Stock storage)
        {
            Console.WriteLine(Messages.ReportTypeMenu);
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Reports.SearchResultsByType(storage.StoredShampoo);
                    break;
                case "2":
                    Reports.SearchResultsByType(storage.StoredConditioner);
                    break;
                case "3":
                    Reports.SearchResultsByType(storage.StoredPerfume);
                    break;
                case "4":
                    Reports.StockContentReport(storage);
                    break;
                default:
                    Console.WriteLine(Messages.InvalidOption);
                    ReportTypeMenu(storage);
                    break;
            }
        }

        public static void ReportMainMenu(Stock storage)
        {
            Console.WriteLine(Messages.ReportSelectionMenu);
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                Reports.ShowFullStock(storage);
            else
                switch (input)
                {
                    case "1":
                        ReportNameMenu(input, storage);
                        break;
                    case "2":
                        ReportTypeMenu(storage);
                        break;
                    case "3":
                        ReportBrandMenu(input, storage);
                        break;
                    default:
                        Console.WriteLine(Messages.InvalidOption);
                        ReportMainMenu(storage);
                        break;
                }
        }


    }
}
