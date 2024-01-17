using System;
using System.Collections.Generic;

namespace ExercicioDeFixacaoVet
{
    class Program
    {
        // Define uma estrutura 'Student' para armazenar informações de estudantes.
        // Cada estudante possui um nome e um email.
        struct Student
        {
            public string Name;
            public string Email;
        }

        static void Main()
        {
            int numRooms = 10; // Define o número total de quartos na pensao.
            Student[] students = new Student[numRooms]; // Cria um array de estudantes com o mesmo número de quartos.

            Console.Write("Digite o número de estudantes (1 a 10): ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"\nRegistro do Estudante {i + 1}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();

                int roomNumber;
                do
                {
                    Console.Write("Escolha um quarto (0 a 9): ");
                    roomNumber = int.Parse(Console.ReadLine());

                    if (roomNumber < 0 || roomNumber >= numRooms)
                    {
                        Console.WriteLine("Número de quarto inválido. Escolha um número entre 0 e 9.");
                    }
                    else if (students[roomNumber].Name != null)
                    {
                        Console.WriteLine($"O quarto {roomNumber} já está ocupado por {students[roomNumber].Name}.");
                        roomNumber = -1; // Definir roomNumber como -1 para forçar a entrada do número do quarto novamente
                    }
                    else
                    {
                        students[roomNumber].Name = name;
                        students[roomNumber].Email = email;
                        Console.WriteLine($"Aluguel do quarto {roomNumber} registrado com sucesso.");
                    }
                } while (roomNumber < 0);
            }

            Console.WriteLine("\nRelatório de Ocupações:");
            for (int i = 0; i < numRooms; i++)
            {
                if (students[i].Name != null)
                {
                    Console.WriteLine($"Quarto {i}: {students[i].Name}, {students[i].Email}");
                }
            }
        }
    }
}
