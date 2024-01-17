//public permite que o atributo ou metodo seja usado em outro arquivo
using System;

namespace PooIntroIII
{
    internal class Triangulo
    {
        public double A; //atributos da class
        public double B; //atributos da class
        public double C; //atributos da class

        public double Area() // se o metodo nao retorna nada , usa-se a palavra "void"
        {
            //corpo do metodo
            double p = (A + B + C) / 2.0;
            return  Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            //return raiz;
        }
    }
}

