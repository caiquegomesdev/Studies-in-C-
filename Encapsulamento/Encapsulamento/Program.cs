using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("T"); //Set altera
            

            Console.WriteLine(p.GetNome()); // Get pega
            
        }
    }
}