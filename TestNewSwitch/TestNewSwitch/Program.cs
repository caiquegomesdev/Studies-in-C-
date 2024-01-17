namespace TestNewSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());

            string diaDaSemana = numero switch
            {
                1 => "Domingo",
                2 => "Segunda",
                3 => "Terca",
                4 => "Quarta",
                5 => "Quinta",
                6 => "Sexta",
                7 => "Sabado",
                _ => "Dia Invalido"
            };
            Console.WriteLine(diaDaSemana);
        }
    }
}