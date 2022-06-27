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


        void validaInput()
        {

        }

        string input;

        void MenuMarca() 
        {
        }

        void MenuNome()
        {
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
                default:
                    Console.WriteLine("Opção inválida.");
                    MenuTipo();
                    break;
            }
        }

        void MenuDeSelecao()
        {
            Console.WriteLine(Messages.ReportSelectionMenu);
            input = Console.ReadLine();
            if (input == null)
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
                        Console.WriteLine("Opção inválida.");
                        MenuDeSelecao();
                        break;
                }
        }
    }
}
