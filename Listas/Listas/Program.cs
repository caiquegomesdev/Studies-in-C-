using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args) {
        
            List<string> list = new List<string>();

            list.Add("Gomes"); //0
            list.Add("Firmino"); //1
            list.Add("Maicon");//3
            list.Add("Fabricio"); //4
            list.Add("Lucas");//5
            list.Insert(2, "Guanabara");//2

            foreach (var obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List Count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'G');
            Console.WriteLine("First 'G': " + s1);

            string s2 = list.FindLast(x => x[0] ==  'G');
            Console.WriteLine("Last 'G': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'G');
            Console.WriteLine("First Position 'G': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'G');
            Console.WriteLine("Last Position 'G': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5 );
            Console.WriteLine("------------------------------");
            foreach ( string obj in list2) {
                Console.WriteLine(obj);
            }

            list.Remove("Lucas");
            Console.WriteLine("------------------------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(2);
            Console.WriteLine("------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2,2);
            Console.WriteLine("------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'F');
            Console.WriteLine("------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            

        }
    }
}
