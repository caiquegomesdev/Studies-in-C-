

namespace ExercicioDeFixacaoHerancaEPolimorfismo.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {Price + CustomsFee:F2} (Customs fee: $ {CustomsFee:F2})";
        }
    }
}
