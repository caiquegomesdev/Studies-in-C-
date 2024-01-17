using System;

namespace ExercicioFixacaoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de linhas (M): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Informe o número de colunas (N): ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            Console.WriteLine("Informe os elementos da matriz:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Matriz[{i}][{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Informe o número a ser buscado (X): ");
            int x = int.Parse(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine($"O número {x} foi encontrado na posição ({i}, {j}).");

                        // Verificar valores à esquerda, acima, à direita e abaixo de X
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine($"Acima: {matriz[i - 1, j]}");
                        }
                        if (j - 1 >= 0)
                        {
                            Console.WriteLine($"À esquerda: {matriz[i, j - 1]}");
                        }
                        if (j + 1 < n)
                        {
                            Console.WriteLine($"À direita: {matriz[i, j + 1]}");
                        }
                        if (i + 1 < m)
                        {
                            Console.WriteLine($"Abaixo: {matriz[i + 1, j]}");
                        }

                        encontrado = true;
                    }
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"O número {x} não foi encontrado na matriz.");
            }
        }
    }
}