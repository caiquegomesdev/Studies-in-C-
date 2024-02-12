
using System;
using System.Collections.Generic;
using ExercicioDeFixacaoHerancaEPolimorfismo.Entities;

namespace ExercicioDeFixacaoHerancaEPolimorfismo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                switch (type)
                {
                    case 'c':
                        products.Add(new Product(name, price));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (MM/DD/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, manufactureDate));
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine());
                        products.Add(new ImportedProduct(name, price, customsFee));
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        i--;  // Decrement to repeat the current iteration
                        break;
                }
            }

            Console.WriteLine("\nPRICE TAGS:");

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
