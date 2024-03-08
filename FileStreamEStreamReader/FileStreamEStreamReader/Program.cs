<<<<<<< HEAD
﻿using System;
using System.IO;
namespace FileStreamEStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string path = @"C:\Windows\Temp\file1.txt";
                StreamReader sr = null;
                try
                {
                    sr = File.OpenText(path);
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (sr != null) sr.Close();
                }
            }
        }
    }
=======
﻿using System;
using System.IO;
namespace FileStreamEStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string path = @"C:\Windows\Temp\file1.txt";
                StreamReader sr = null;
                try
                {
                    sr = File.OpenText(path);
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (sr != null) sr.Close();
                }
            }
        }
    }
>>>>>>> 1ca3199ed7d57dfcdade365a5d625c1855f8c4d0
}