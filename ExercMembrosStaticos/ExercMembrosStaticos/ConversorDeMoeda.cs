using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercMembrosStaticos
{
    class ConversorDeMoeda
    {
        private double cotacaoDolar;
        private double taxaIOF = 0.06; // Taxa de IOF de 6%

        public ConversorDeMoeda(double cotacaoDolar)
        {
            this.cotacaoDolar = cotacaoDolar;
        }

        public double ConverterDolarParaReal(double valorEmDolar)
        {
            double valorEmReais = valorEmDolar * cotacaoDolar;
            double valorComIOF = valorEmReais + (valorEmReais * taxaIOF);
            return valorComIOF;
        }
    }

}
