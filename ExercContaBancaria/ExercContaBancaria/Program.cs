using System;
using System.Globalization;

namespace ExercContaBancaria
{
    class Program
    {
        static void Main()
        {

            Console.Write("Número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Deseja fazer um depósito inicial (s/n)? ");
            char resposta = char.ToLower(Console.ReadKey().KeyChar); // keyChar para escolhe s ou n // tolower caracter minusculo
            Console.WriteLine();

            ContaBancaria conta;

            if (resposta == 's')
            {
                Console.Write("Valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numeroConta, nomeTitular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nomeTitular);
            }

            Console.WriteLine("================================================");
            conta.MostrarDados();
            Console.WriteLine("================================================");

            Console.Write("Realizar um depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            conta.Deposito(valorDeposito);

            Console.WriteLine("================================================");
            conta.MostrarDados();
            Console.WriteLine("================================================");

            Console.Write("Realizar um saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            conta.Saque(valorSaque);

            Console.WriteLine("================================================");
            conta.MostrarDados();
            Console.WriteLine("================================================");
        }
    }

}