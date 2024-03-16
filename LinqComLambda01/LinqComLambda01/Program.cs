using System;
using System.Linq;
using LinqComLambda01.Entities;
using System.Collections.Generic;

namespace LinqComLambda01
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            Category c1 = new Category() { Id = 1, Name = "Ferramentas", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computadores", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletrônicos", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computador", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Martelo", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Serra", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Impressora", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Caixa de Som", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Trena", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("NÍVEL 1 E PREÇO < 900:", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NOMES DE PRODUTOS DE FERRAMENTAS", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NOMES COMEÇADOS COM 'C' E OBJETO ANÔNIMO", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("PEDIDO DE NÍVEL 1 POR PREÇO E DEPOIS POR NOME", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("NÍVEL 1 PEDIDO POR PREÇO DEPOIS POR NOME PULAR 2 LEVAR 4", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("Primeiro teste1 ou padrão: " + r6);
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("Primeiro teste2 ou padrão: " + r7);
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Teste único ou padrão1: " + r8);
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Teste único ou padrão2: " + r9);
            Console.WriteLine();

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Preço máximo: " + r10);
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Preço mínimo: " + r11);
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Preços de soma da categoria 1: " + r12);
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Categoria 1 Preços médios: " + r13);
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Categoria 5 Preços médios: " + r14);
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Soma agregada da categoria 1: " + r15);
            Console.WriteLine();

            var r16 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Categoria " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}