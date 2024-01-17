using System;
using System.Globalization;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros intreiros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1;  i <= N; i++) //ou i = i + 1 mesma coisa de i++
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}