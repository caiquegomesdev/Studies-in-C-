using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insira os dados do aluguel");

        Console.Write("Modelo de carro: ");
        string modeloCarro = Console.ReadLine();

        Console.Write("Retirada (dd/MM/yyyy HH:mm): ");
        DateTime retirada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);

        Console.Write("Retorno (dd/MM/yyyy HH:mm): ");
        DateTime retorno = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);

        Console.Write("Insira o preço por hora: ");
        double precoPorHora = double.Parse(Console.ReadLine());

        Console.Write("Insira o preço por dia: ");
        double precoPorDia = double.Parse(Console.ReadLine());

        AluguelCarro aluguel = new AluguelCarro(modeloCarro, retirada, retorno, precoPorHora, precoPorDia);
        NotaDePagamento nota = aluguel.GerarNotaDePagamento();

        Console.WriteLine("FATURA:");
        Console.WriteLine($"Pagamento básico: {nota.PagamentoBasico.ToString("F2")}");
        Console.WriteLine($"Imposto: {nota.Imposto.ToString("F2")}");
        Console.WriteLine($"Pagamento total: {nota.PagamentoTotal.ToString("F2")}");
    }
}

class AluguelCarro
{
    public string ModeloCarro { get; set; }
    public DateTime Retirada { get; set; }
    public DateTime Retorno { get; set; }
    public double PrecoPorHora { get; set; }
    public double PrecoPorDia { get; set; }

    public AluguelCarro(string modeloCarro, DateTime retirada, DateTime retorno, double precoPorHora, double precoPorDia)
    {
        ModeloCarro = modeloCarro;
        Retirada = retirada;
        Retorno = retorno;
        PrecoPorHora = precoPorHora;
        PrecoPorDia = precoPorDia;
    }

    public NotaDePagamento GerarNotaDePagamento()
    {
        double duracaoHoras = (Retorno - Retirada).TotalHours;
        double pagamentoBasico = (duracaoHoras <= 12) ? duracaoHoras * PrecoPorHora : Math.Ceiling(duracaoHoras / 24) * PrecoPorDia;
        double imposto = (pagamentoBasico <= 100.00) ? pagamentoBasico * 0.20 : pagamentoBasico * 0.15;
        double pagamentoTotal = pagamentoBasico + imposto;

        return new NotaDePagamento(pagamentoBasico, imposto, pagamentoTotal);
    }
}

class NotaDePagamento
{
    public double PagamentoBasico { get; set; }
    public double Imposto { get; set; }
    public double PagamentoTotal { get; set; }

    public NotaDePagamento(double pagamentoBasico, double imposto, double pagamentoTotal)
    {
        PagamentoBasico = pagamentoBasico;
        Imposto = imposto;
        PagamentoTotal = pagamentoTotal;
    }
}
