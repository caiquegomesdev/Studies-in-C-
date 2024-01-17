using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = ++a;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a -= 2;
            Console.WriteLine(a);

            a *= 2;
            Console.WriteLine(a);

            a /= 2;
            Console.WriteLine(a);

            a %= 2;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            Console.WriteLine("-----------------------------");
            
            Console.WriteLine(b);
        }
    }
}