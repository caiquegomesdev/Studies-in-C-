<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace HashSetESortedSet01
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            Console.WriteLine(set.Contains("Notebook"));
            foreach (String p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;

namespace HashSetESortedSet01
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            Console.WriteLine(set.Contains("Notebook"));
            foreach (String p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}
>>>>>>> 1ca3199ed7d57dfcdade365a5d625c1855f8c4d0
