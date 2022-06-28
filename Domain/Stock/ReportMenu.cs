using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Stock
{
    public class ReportMenu
    {
        private Reports reports;
        private Stock stock;
        /*public ReportMenu(Reports reports)
        {
            this.reports = reports;
        }*/

        string input;

        public void ReportInputValidation()
        {
            input = "";
            while (string.IsNullOrWhiteSpace(input))
            {
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    Console.WriteLine(Messages.NullInput);
            }
        }


        public void ReportBrandMenu()
        {
            Console.WriteLine(Messages.ReportBrandMenu);
            ReportInputValidation();
            reports.SearchResultsByBrand(input);
        }

        public void ReportNameMenu()
        {
            Console.WriteLine(Messages.ReportNameMenu);
            ReportInputValidation();
            reports.SearchResultsByName(input);
        }
        public void ReportTypeMenu()
        {
            Console.WriteLine(Messages.ReportTypeMenu);
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    reports.SearchResultsByType(stock.StoredShampoo);
                    break;
                case "2":
                    reports.SearchResultsByType(stock.StoredConditioner);
                    break;
                case "3":
                    reports.SearchResultsByType(stock.StoredPerfume);
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
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                reports.ShowFullStock();
            else
                switch (input)
                {
                    case "1":
                        ReportNameMenu();
                        break;
                    case "2":
                        ReportTypeMenu();
                        break;
                    case "3":
                        ReportBrandMenu();
                        break;
                    default:
                        Console.WriteLine(Messages.InvalidOption);
                        ReportMainMenu();
                        break;
                }
        }
    }
}
