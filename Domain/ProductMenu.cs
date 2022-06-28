using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Domain.Common;

namespace Stock.Domain
{
    public class ProductMenu
    {
        private Stock storage;
        private Reports reports;
        private ProductRegistration registry;


        public ProductMenu(Stock storage, Reports reports, ProductRegistration registry)
        {
            this.storage = storage;
            this.registry = registry;
            this.reports = reports;
        }
        public void BeginProgram()
        {
            MenuSelection();
        }

        private void NewProductTest()
        {
            Product newProduct = registry.NewProductProperties();
            registry.AddNewProductToStock(newProduct);
        }

        private void MenuSelection()
        {
            Console.WriteLine(Messages.MenuProductTest);
            string userInput = InputServices.UserInput();
            switch (userInput)
            {
                case "1":
                    NewProductTest();
                    ReturnProgram();
                    return;
                case "2":
                    PrintStock();
                    ReturnProgram();
                    return;
                case "3":
                    OpenProduct();
                    ReturnProgram();
                    return;
                default:
                    Console.WriteLine(Messages.formatError);
                    MenuSelection();
                    return;
            }
        }

        private void OpenProduct()
        {
            Category wantedProductType = InputServices.SelectCategory();
            Usage wantedProductUsage = InputServices.SelectUsage();
            Species wantedProductSpecies = InputServices.SelectSpecies();
            Product removedProduct = storage.RemoveFromStock(wantedProductType, wantedProductUsage, wantedProductSpecies);
            reports.PrintProduct(removedProduct);
        }

        private void PrintStock()
        {
            List<Product> stockCollection = storage.GetFullStock();

            foreach (Product item in stockCollection)
            {
                reports.PrintProduct(item);
            }
        }

        private void ReturnProgram()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(Messages.returnEntryKey);
            Console.ReadKey();
            MenuSelection();
            return;
        }

        public Stock CreatedStock()
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

        public void DefaultMenuStock()
        {
            Stock storage = CreatedStock();
            string inputType = InputServices.UserInput();
            switch (inputType)
            {
                case "1":
                    storage.AddToStock(registry.NewProductProperties());
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

        public void ReportBrandMenu(string userInput)
        {
            Console.WriteLine(Messages.ReportBrandMenu);
            InputServices.UserInput();
            reports.SearchResultsByBrand(userInput);
        }

        public void ReportNameMenu(string userInput)
        {
            Console.WriteLine(Messages.ReportNameMenu);
            InputServices.UserInput();
            reports.SearchResultsByName(userInput);
        }

        public void ReportTypeMenu()
        {
            Console.WriteLine(Messages.ReportTypeMenu);
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    reports.SearchResultsByType(storage.StoredShampoo);
                    break;
                case "2":
                    reports.SearchResultsByType(storage.StoredConditioner);
                    break;
                case "3":
                    reports.SearchResultsByType(storage.StoredPerfume);
                    break;
                case "4":
                    reports.StockContentReport();
                    break;
                default:
                    Console.WriteLine(Messages.InvalidOption);
                    ReportTypeMenu();
                    break;
            }
        }

        public void ReportMainMenu()
        {
            Console.WriteLine(Messages.ReportSelectionMenu);
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                reports.ShowFullStock();
            else
                switch (input)
                {
                    case "1":
                        ReportNameMenu(input);
                        break;
                    case "2":
                        ReportTypeMenu();
                        break;
                    case "3":
                        ReportBrandMenu(input);
                        break;
                    default:
                        Console.WriteLine(Messages.InvalidOption);
                        ReportMainMenu();
                        break;
                }
        }

       
    }
}
