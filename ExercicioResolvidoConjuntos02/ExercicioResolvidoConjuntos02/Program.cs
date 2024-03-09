using System;
using System.Collections.Generic;

namespace ExercicioResolvidoConjuntos02
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("Quantos alunos para o curso A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseA.Add(cod);
            }

            Console.Write("Quantos alunos para o curso B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseB.Add(cod);
            }

            Console.Write("Quantos alunos para o curso C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseC.Add(cod);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total de alunos: " + all.Count);
        }
    }
}

/*Em um portal de cursos online, cada usuário possui um código único, representado por um número inteiro.
 Cada instrutor  do portal pode ter vários cursos, sendo que um mesmo aluno pode se
 matricular em quantos cursos quiser.Assim, o número total de alunos de um instrutor não
 é simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haver
 alunos repetidos em mais de um curso.
 O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.
 Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar a
 quantidade total e alunos dele.*/