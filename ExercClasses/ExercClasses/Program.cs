using System;
using System.Globalization;

namespace ExercClasses
{
class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();
            
        Console.Write("Digite a largura do retângulo: ");
        retangulo.Largura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite a altura do retângulo: ");
        retangulo.Altura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double area = retangulo.Area();
        double perimetro = retangulo.Perimetro();
        double diagonal = retangulo.Diagonal();

        Console.WriteLine("Área do retângulo: " + area.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Perímetro do retângulo: " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Diagonal do retângulo: " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
    }
}


}
