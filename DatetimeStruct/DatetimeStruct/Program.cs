using System;
namespace DatetimeStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime agora = DateTime.Now;
            Console.WriteLine(agora);
            Console.WriteLine(agora.Ticks);

            DateTime dataEspecifica = new DateTime(2023, 11, 3);
            Console.WriteLine(dataEspecifica);

            DateTime data = DateTime.Now;
            DateTime dataDaquiADoisDias = data.AddDays(2);
            DateTime dataUmaHoraAtras = data.AddHours(-1);
            Console.WriteLine(dataDaquiADoisDias);
            Console.WriteLine(dataUmaHoraAtras);

            DateTime data1 = new DateTime(2023, 11, 3);
            DateTime data2 = new DateTime(2023, 11, 5);
            TimeSpan diferenca = data2 - data1;
            Console.WriteLine($"Diferença: {diferenca.Days} dias");

            DateTime dataa = DateTime.Now;
            string dataFormatada = dataa.ToString("dd/MM/yyyy HH:mm:ss");
            Console.WriteLine(dataFormatada);

            DateTime data4 = DateTime.Now;
            int dia = data4.Day;
            int mes = data4.Month;
            int ano = data4.Year;
            int hora = data4.Hour;
            int minuto = data4.Minute;
            int segundo = data4.Second;
            Console.WriteLine(dia);
            Console.WriteLine(mes);
            Console.WriteLine(ano);
            Console.WriteLine(hora);
            Console.WriteLine(minuto);
            Console.WriteLine(segundo);





        }
    }
}