<<<<<<< HEAD
﻿using System;

namespace HerancaMultiplaEOProblema.Devices
{
    class Printer : Device, IPrinter
    {

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
=======
﻿using System;

namespace HerancaMultiplaEOProblema.Devices
{
    class Printer : Device, IPrinter
    {

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
>>>>>>> 1ca3199ed7d57dfcdade365a5d625c1855f8c4d0
}