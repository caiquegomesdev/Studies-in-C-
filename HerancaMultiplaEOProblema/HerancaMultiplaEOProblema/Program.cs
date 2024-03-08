<<<<<<< HEAD
﻿using System;
using System.Reflection;
using HerancaMultiplaEOProblema.Devices;

namespace HerancaMultiplaEOProblema
{
    class Program
    {
        static void Main(string[] args)
        {

            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
=======
﻿using System;
using System.Reflection;
using HerancaMultiplaEOProblema.Devices;

namespace HerancaMultiplaEOProblema
{
    class Program
    {
        static void Main(string[] args)
        {

            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
>>>>>>> 1ca3199ed7d57dfcdade365a5d625c1855f8c4d0
}