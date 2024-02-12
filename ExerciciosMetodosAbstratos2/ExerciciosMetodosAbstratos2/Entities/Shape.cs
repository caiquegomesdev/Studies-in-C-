using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosMetodosAbstratos2.Entities.Enums;

namespace ExerciciosMetodosAbstratos2.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double CalculateArea();
    }
}
