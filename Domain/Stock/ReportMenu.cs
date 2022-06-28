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

        void validaInput()
        {
            input = "";
            while (string.IsNullOrWhiteSpace(input))
            {
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    Console.WriteLine(Messages.NullInput);
            }
        }


        void MenuMarca()
        {
            Console.WriteLine(Messages.ReportBrandMenu);
            validaInput();
            reports.SearchResultsByBrand(input);
        }

        void MenuNome()
        {
            Console.WriteLine(Messages.ReportNameMenu);
            validaInput();
            reports.SearchResultsByName(input);
        }
        void MenuTipo()
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
                    MenuTipo();
                    break;
            }
        }

        void MenuDeSelecao()
        {
            Console.WriteLine(Messages.ReportSelectionMenu);
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                reports.ShowFullStock();
            else
                switch (input)
                {
                    case "1":
                        MenuNome();
                        break;
                    case "2":
                        MenuTipo();
                        break;
                    case "3":
                        MenuMarca();
                        break;
                    default:
                        Console.WriteLine(Messages.InvalidOption);
                        MenuDeSelecao();
                        break;
                }
        }
    }
}
