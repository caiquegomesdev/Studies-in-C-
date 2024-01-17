using System;
using System.Globalization;

namespace ExercClasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Digite o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Digite o salário bruto do funcionário: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor do imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Funcionário:");
            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Salário Líquido: $" + funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite a porcentagem de aumento salarial: ");
            double percentualAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(percentualAumento);

            Console.WriteLine("Dados do Funcionário após o aumento:");
            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Salário Líquido: $" + funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }


}