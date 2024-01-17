using System;
using System.Globalization;

namespace ExercClasses2
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double percentualAumento)
        {
            SalarioBruto += SalarioBruto * (percentualAumento / 100.0);
        }
    }

}
