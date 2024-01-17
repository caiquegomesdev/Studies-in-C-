using System;

namespace Matrizes02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor de N (ordem da matriz): ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            Console.WriteLine("Informe os elementos da matriz:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Matriz[{i}][{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Diagonal Principal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            int countNegativos = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        countNegativos++;
                    }
                }
            }

            Console.WriteLine("\nQuantidade de valores negativos na matriz: " + countNegativos);
        }
    }
}