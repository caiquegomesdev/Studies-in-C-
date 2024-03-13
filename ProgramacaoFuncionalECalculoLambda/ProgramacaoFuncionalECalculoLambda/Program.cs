using System;
using System.Collections.Generic;
namespace TransparenciaReferencial
{
    class Program
    {
        public static int globalValue = 3;
        static void Main(string[] args)
        {
            int[] vect = new int[] { 3, 4, 5 };
            ChangeOddValues(vect);
            Console.WriteLine(string.Join(" ", vect));
        }
        public static void ChangeOddValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            }
        }
    }
}


/*
 * Inferencia de Tipos
 * class Program
{
    static int CompareProducts(Product p1, Product p2)
    {
        return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
    }
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        list.Add(new Product("TV", 900.00));
        list.Add(new Product("Notebook", 1200.00));
        list.Add(new Product("Tablet", 450.00));
        list.Sort(CompareProducts);
        (...)*/

/*
 * O que são "expressões lambda"?
 Em programação funcional, expressão lambda corresponde a uma
 função anônima de primeira classe.
 * 
class Program
{
    static int CompareProducts(Product p1, Product p2)
    {
        return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
    }
    static void Main(string[] args)
    {
        (...)
 list.Sort(CompareProducts);
        list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
        (...)*/