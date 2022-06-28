using Stock.Domain.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Services
{
    
    /*
    public class StockMain
    {
        public static int option;
        public static bool loop;
        public static string validate;

        public static void DefaultMenu()
        {
            List<string> options = new List<string>() { "1", "2", "3", "4" };
            string inputUser;
            do
            {
                Console.WriteLine("Opções de produtos:");
                Console.WriteLine("1 - Cadastro de Produtos\n2 - Buscar produtos\n3 - Relatório do Estoque\n4 - Voltar ao menu anterior");
                inputUser = Console.ReadLine();
                while (!options.Contains(inputUser))
                {
                    Console.WriteLine("Digite um valor válido:");
                    inputUser = Console.ReadLine();
                }
                switch (option)
                {
                    case 1:
                        ProductRegistration.NewProductRegistry(); // criar classe estatica ou instanciar objeto?
                        break;
                    case 2:
                        Stock; // verificar se o metodo certo 
                        break;
                    case 3:

                        break;
                    case 4:
                        break;
                }
                do
                {
                    Console.WriteLine("Deseja realizar outra operação (S/N)?");
                    validate = Console.ReadLine().ToUpper();
                } while (!Validations.Resposta(validate));
                loop = Validations.SimNao(validate);
            } while (loop);
        }
    }
    */
    
}
