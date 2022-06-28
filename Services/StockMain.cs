using Stock.Domain.Common;
using Stock.Domain.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Services
{

    public class StockMain
    {
        public static int option;
        public static bool loop;
        public static string validate;
        public static void DefaultMenu()
        {
            
            
            Stock.Domain.Stock.Stock estoque = new Stock.Domain.Stock.Stock(); 
              
            
                
                {
                    Console.WriteLine("Deseja realizar outra operação (S/N)?");
                    validate = Console.ReadLine().ToUpper();
                } while (!Validations.Resposta(validate));
                loop = Validations.SimNao(validate);
            } while (loop);
        }
    }
}
