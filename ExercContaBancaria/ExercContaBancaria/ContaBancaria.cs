using System;
using System.Globalization;

namespace ExercContaBancaria
{

    class ContaBancaria
    {
        public int NumeroConta { get; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = 0.0;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial)
            : this(numeroConta, nomeTitular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de ${valor.ToString("F2", CultureInfo.InvariantCulture)} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser maior que zero.");
            }
        }

        public void Saque(double valor)
        {
            if (valor > 0)
            {
                if (Saldo >= valor)
                {
                    Saldo -= valor;
                    Console.WriteLine($"Saque de ${valor.ToString("F2", CultureInfo.InvariantCulture)} realizado com sucesso.", CultureInfo.InvariantCulture);
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para realizar o saque.");
                }
            }
            else
            {
                Console.WriteLine("O valor do saque deve ser maior que zero.");
            }
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Conta: {NumeroConta}");
            Console.WriteLine($"Titular: {NomeTitular}");
            Console.WriteLine($"Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }

}
