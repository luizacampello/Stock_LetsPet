using Stock.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain
{
    public class Program
    {
        public static void Main()
        {
            Stock storage = new();
            Reports reports = new(storage);
            ProductRegistration registry = new ProductRegistration(storage);
            //ProductInUse productInUse = new();
            ProductMenu productMenu = new ProductMenu(storage, reports, registry/*, productInUse*/);

            productMenu.BeginProgram();
        }
    }
}

