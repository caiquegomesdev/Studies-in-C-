using System;
using System.Globalization;

namespace ExercClass02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();

            Console.WriteLine("Dados do Primeiro funcionario: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo funcionario: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalarial = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("Salario medio = "+ mediaSalarial.ToString("F2",CultureInfo.InvariantCulture));
        }
    }

}