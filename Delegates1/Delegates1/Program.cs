using Delegates1.Services;
using System;

namespace Delegates1
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            // BinaryNumericOperationop= CalculationService.Sum;
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            // doubleresult= op(a, b);
            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}