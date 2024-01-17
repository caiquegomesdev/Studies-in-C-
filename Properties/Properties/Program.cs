using Properties;
using System;
using System.Globalization;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome= "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco); //GEt pega //SET altera
        }
    }
}