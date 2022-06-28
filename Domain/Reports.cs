using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain
{
    public class Reports
    {
        private Stock storage;
        public Reports(Stock storage)
        {
            this.storage = storage;
        }
        public void StockContentReport()
        {
            if (storage.ProductCategoryQuantity(Category.Shampoo) != 0)
            {
                Console.WriteLine(Messages.listOfProducts + Category.Shampoo + ":");
                foreach (Product shampoo in storage.StoredShampoo)
                    PrintProduct(shampoo);
            }
            else
                Console.WriteLine(Messages.noProductsAvailable + Category.Shampoo + ".");

            if (storage.StoredCondicionador.Count != 0)
            {
                Console.WriteLine(Messages.listOfProducts + Category.Condicionador + ":");
                foreach (Product conditioner in storage.StoredCondicionador)
                    PrintProduct(conditioner);
            }
            else
                Console.WriteLine(Messages.noProductsAvailable + Category.Condicionador + ".");

            if (storage.StoredPerfume.Count != 0)
            {
                Console.WriteLine(Messages.listOfProducts + Category.Perfume + ":");
                foreach (Product perfume in storage.StoredPerfume)
                    PrintProduct(perfume);
            }
            else
                Console.WriteLine(Messages.noProductsAvailable + Category.Perfume + ".");
        }

        public void SearchResultsByType(List<Product> products)
        {
            foreach (Product p in products)
                PrintProduct(p);
        }

        public void SearchResultsByName(string nameInput)
        {
            bool found = false;
            foreach (Product product in storage.GetFullStock())
            {
                if (product.Name == nameInput)
                {
                    PrintProduct(product);
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine(Messages.noResults);
        }

        public void SearchResultsByBrand(string brandInput)
        {
            bool found = false;
            foreach (Product product in storage.GetFullStock())
            {
                if (product.Brand == brandInput)
                {
                    PrintProduct(product);
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine(Messages.noResults);
        }

        public void ShowFullStock()
        {
            foreach (Product product in storage.GetFullStock())
                PrintProduct(product);
        }

        public void PrintProduct(Product product)
        {
            Console.WriteLine(@$"Nome: {product.Name}
Marca: {product.Brand}
- Categoria: {product.Category}
- Espécie: {product.Species}
- Uso: {product.Usage}
- Preço: {product.Price.ToString("C2", CultureInfo.CurrentCulture)}
- Volume disponível: {product.CurrentVolume}/{product.TotalVolume}
- Data de validade: {product.ExpirationDate.ToString("dd/MM/yyyy")}
------------------------------------------------------------
");
        }

    }
}
