using System;

// Testando conhecimentos em C# 
//Calculadora utilizando class no codigo principal Convert e SwitchCase

namespace TestOne
{
    using System;

    class Calculadora
    {
        public double Adicionar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                return 0;
            }
            return num1 / num2;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculadora calculadora = new Calculadora();

            Console.WriteLine("Calculadora em C#");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int escolha = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (escolha)
            {
                case 1:
                    resultado = calculadora.Adicionar(num1, num2);
                    break;
                case 2:
                    resultado = calculadora.Subtrair(num1, num2);
                    break;
                case 3:
                    resultado = calculadora.Multiplicar(num1, num2);
                    break;
                case 4:
                    resultado = calculadora.Dividir(num1, num2);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }

            Console.WriteLine("Resultado: " + resultado);
        }
    }

}