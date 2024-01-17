using System;
using System.Globalization;

namespace ExercicioDeFixacao { 
    class Program {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.0;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preco e $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preco e $ {preco2}");

            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genero {genero}");
            Console.WriteLine($"Medida com oito casas decimais: {medida:f8}");
            Console.WriteLine($"Arredondado (tres casas decimais): {medida:f3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida:f3}", CultureInfo.InvariantCulture);
        }
    }
}