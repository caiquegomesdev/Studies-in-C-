using System;

namespace ConversaoImplicitaECasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            int b;

            a = 5.1;
            b = (int)a;

            Console.WriteLine(b);

            int c = 5;
            int d = 2;

            double resultado =  (double)c/d; //casting
            Console.WriteLine(resultado);

        }
    }
}
