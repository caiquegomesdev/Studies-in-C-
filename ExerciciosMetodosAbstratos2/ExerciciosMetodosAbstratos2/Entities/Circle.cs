using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosMetodosAbstratos2.Entities.Enums;

namespace ExerciciosMetodosAbstratos2.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
