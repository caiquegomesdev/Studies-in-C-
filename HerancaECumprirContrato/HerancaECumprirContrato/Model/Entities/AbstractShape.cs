using HerancaECumprirContrato.Model.Enums;


namespace HerancaECumprirContrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {

        public Color Color { get; set; }

        public abstract double Area();
    }
}