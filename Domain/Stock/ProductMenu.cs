using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Domain.Common;
using Stock.Domain.Stock;
using Stock.Services;

namespace Stock.Domain.Stock
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
            Product newProduct = ProductRegistration.NewProductRegistry();
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
            Product removedProduct = Stock.RemoveFromStock(wantedProductType, wantedProductUsage, wantedProductSpecies);
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



    }
}
