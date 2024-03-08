<<<<<<< HEAD
﻿using System;

namespace HerancaMultiplaEOProblema.Devices {
    class ComboDevice : Device, IScanner, IPrinter {
        public void Print(string document) {
            Console.WriteLine("Combodevice print " + document);
        }

        public override void ProcessDoc(string document) {
            Console.WriteLine("Combodevice processing " + document);
        }

        public string Scan() {
            return "Combodevice scan result";
        }
    }
=======
﻿using System;

namespace HerancaMultiplaEOProblema.Devices {
    class ComboDevice : Device, IScanner, IPrinter {
        public void Print(string document) {
            Console.WriteLine("Combodevice print " + document);
        }

        public override void ProcessDoc(string document) {
            Console.WriteLine("Combodevice processing " + document);
        }

        public string Scan() {
            return "Combodevice scan result";
        }
    }
>>>>>>> 1ca3199ed7d57dfcdade365a5d625c1855f8c4d0
}