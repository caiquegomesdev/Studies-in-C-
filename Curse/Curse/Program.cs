using System;

namespace Curse
{
   class Program { 
    static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F'; // aspas simples serve pra identificar caractere
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Gomes"; //aspas duplas representa String
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            int n01 = int.MaxValue;
            int n02 = int.MinValue;
            sbyte n03 = sbyte.MaxValue;
            
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n01);
            Console.WriteLine(n02);
            Console.WriteLine(n03);
        }
    }
}