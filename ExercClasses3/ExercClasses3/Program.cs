using System;
using System.Globalization;

namespace ExercClasses3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o nome do aluno:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a nota do primeiro trimestre:");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota do segundo trimestre:");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota do terceiro trimestre:");
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Aluno aluno = new Aluno
            {
                Nome = nome,
                Nota1 = nota1,
                Nota2 = nota2,
                Nota3 = nota3
            };

            Console.WriteLine($"Nota final do aluno {aluno.Nome}: {aluno.CalcularNotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Situação: {aluno.Situacao()}");
        }
    }

}