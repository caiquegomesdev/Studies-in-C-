<<<<<<< HEAD
﻿using System;
using System.IO;
using System.Collections.Generic;
namespace InterfaceIComparable01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
=======
﻿using System;
using System.IO;
using System.Collections.Generic;
namespace InterfaceIComparable01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
>>>>>>> 1ca3199ed7d57dfcdade365a5d625c1855f8c4d0
