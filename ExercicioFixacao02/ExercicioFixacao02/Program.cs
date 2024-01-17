using System;
using System.Globalization;

namespace ExercicioFixacao02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            int quartos = int.Parse(Console.ReadLine());
            double precprod = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            int year = int.Parse(vet[1]);
            double alt = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Voce Digitou: ");
            Console.WriteLine("Seu nome completo: " + nome);
            Console.WriteLine("Quantos quartos tem na sua casa: " + quartos);
            Console.WriteLine("Qual o preco do produto: " + precprod.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Seu sobre nome e " + name);
            Console.WriteLine("Sua idade e " + year);
            Console.WriteLine("Sua altura e " + alt.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}