using System;
using System.Globalization;

namespace ResolvProblUML
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome do Produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produto a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p );

            Console.WriteLine();
            Console.Write("Digite o numero de produto a ser removido no estoque: ");
            qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}