using System.Globalization;
namespace Properties
{
    class Produto
    {
        //1- atributo privativo
        private string _nome; // Nome nao aceita o autoproperties por teu uma logica particular customizada
        public double Preco { get; private set; } // AUTOPROPERTIES //2- propriedades autoimplementadas
        public int Quantidade { get; private set; } // AUTOPROPERTIES //2- propriedades autoimplementadas


        //3-CONSTRUTORES
        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }// 3-CONSTRUTORES

        //4-PROPIREDADES CUSTOMIZADAS
        public string Nome // Properties
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        } 

        //5- OUTROS METODOS DA CLASS
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}