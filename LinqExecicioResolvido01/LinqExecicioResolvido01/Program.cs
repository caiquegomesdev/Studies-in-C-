using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnalisadorProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o caminho completo do arquivo:");
            string caminhoArquivo = Console.ReadLine();

            List<Produto> produtos = LerProdutosDoArquivo(caminhoArquivo);

            if (produtos.Count > 0)
            {
                double precoMedio = produtos.Average(p => p.Preco);
                Console.WriteLine($"Preço médio: {precoMedio:F2}");

                var produtosAbaixoDaMedia = produtos.Where(p => p.Preco < precoMedio)
                                                     .OrderByDescending(p => p.Preco)
                                                     .Select(p => p.Nome);
                foreach (var nomeProduto in produtosAbaixoDaMedia)
                {
                    Console.WriteLine(nomeProduto);
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto encontrado no arquivo.");
            }
        }

        static List<Produto> LerProdutosDoArquivo(string caminhoArquivo)
        {
            List<Produto> produtos = new List<Produto>();

            try
            {
                using (StreamReader sr = new StreamReader(caminhoArquivo))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] partes = linha.Split(',');
                        if (partes.Length == 2)
                        {
                            string nome = partes[0].Trim();
                            if (double.TryParse(partes[1], out double preco))
                            {
                                produtos.Add(new Produto(nome, preco));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
            }

            return produtos;
        }
    }

    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}

//C:\Windows\Temp\in.txt