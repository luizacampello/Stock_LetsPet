using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Stock
{
    internal class ProductRegistration
    {
        Product newProduct = new Product();
        private int minAmount = 2;
        private int maxAmount = 20;

        void NewProductRegistry()
        {
            Product newProduct = new();
            newProduct.Category = newProductCategory();
            newProduct.Usage = newProductUsage();
            newProduct.Name = newProductName();
            newProduct.Brand = newProductBrand();
        }

        public Category SelectType()
        {            
            Console.WriteLine("Qual o tipo de produto: Digite:\n1 para Shampoo\n2 para Condicionador\n3 para Perfume");
            var inputType = Console.ReadLine();
            switch (inputType)
            {
                case "1":
                    return Category.Shampoo;
                   
                case "2":
                    return Category.Conditioner;
                   
                case "3":
                    return Category.Perfume;
                    
                default:

                    Console.WriteLine("Entrada invalida, tente novamente");
                    SelectType();
                    break;
            }
            return Category.Shampoo;
        }

    }
}
