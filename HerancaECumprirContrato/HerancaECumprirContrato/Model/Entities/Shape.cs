using HerancaECumprirContrato.Model.Enums;


namespace HerancaECumprirContrato.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
