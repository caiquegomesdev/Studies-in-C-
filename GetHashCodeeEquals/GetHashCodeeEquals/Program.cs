<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 1ca3199ed7d57dfcdade365a5d625c1855f8c4d0
}