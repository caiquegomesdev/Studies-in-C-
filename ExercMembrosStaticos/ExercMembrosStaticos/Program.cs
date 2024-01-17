using System;
using System.Globalization;

namespace ExercMembrosStaticos
{
    class Program
    {
        static void Main()
        {
            Console.Write("Informe a cotação do dólar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o valor em dólares a ser comprado: ");
            double valorEmDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ConversorDeMoeda conversor = new ConversorDeMoeda(cotacaoDolar);
            double valorEmReais = conversor.ConverterDolarParaReal(valorEmDolar);

            Console.WriteLine("Valor em reais a ser pago: R$ " + valorEmReais.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}
