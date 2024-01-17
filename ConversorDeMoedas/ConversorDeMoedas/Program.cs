using System;
using System.Globalization;

class Conversao
{
    public static double ConverterParaReais(double valor, string moeda)
    {
        double taxaDeCambio = 0.0;

        switch (moeda.ToUpper())
        {
            case "EURO":
                taxaDeCambio = 5.30; // Substitua pela taxa de câmbio atual para o Euro.
                break;
            case "DOLAR":
                taxaDeCambio = 4.97; // Substitua pela taxa de câmbio atual para o Dólar.
                break;
            case "DINAR":
                taxaDeCambio = 15.97; // Substitua pela taxa de câmbio atual para o Dinar.
                break;
            default:
                Console.WriteLine("Moeda não suportada.");
                break;
        }

        if (taxaDeCambio > 0)
        {
            double valorEmReais = valor * taxaDeCambio;
            return valorEmReais;
        }
        else
        {
            return 0.0; // Moeda não suportada, retorna 0.
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Conversor de Moedas");
        Console.Write("Informe o valor: ");
        string valorString = Console.ReadLine();

        if (double.TryParse(valorString.Replace(',', '.'), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double valor))
        {
            Console.Write("Informe a moeda (EURO, DOLAR, DINAR): ");
            string moeda = Console.ReadLine();

            double valorConvertido = ConverterParaReais(valor, moeda);
            Console.WriteLine($"Valor em Reais: {valorConvertido.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"))}");
        }
        else
        {
            Console.WriteLine("Valor inválido.");
        }
    }
}
