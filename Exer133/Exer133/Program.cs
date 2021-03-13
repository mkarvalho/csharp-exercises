using System;
using System.Collections.Generic;
using Exer133.Entities;

namespace Exer133
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used, imported (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(productType == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customsFee));
                } else if (productType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, date));
                } else
                {
                    products.Add(new Product(name, price));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach (Product product in products)
            {
                Console.WriteLine(product.Pricetag());
            }

        }
    }
}
