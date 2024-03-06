using System;
using GetHashCodeeEquals.Entities;

namespace GetHashCodeeEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = " Maria ", Email = "maria@gmail.com" };
            Client b = new Client { Name = " Gomes ", Email = "gomes@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}