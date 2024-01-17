namespace TestTwo
{
    internal class Program
    {
        public class CalculadoraCientifica
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Calculadora Gomes");
                bool sair = false;

                while (!sair)
                {
                    Console.WriteLine("Escolha uma operação:");
                    Console.WriteLine("1. Adição");
                    Console.WriteLine("2. Subtração");
                    Console.WriteLine("3. Multiplicação");
                    Console.WriteLine("4. Divisão");
                    Console.WriteLine("5. Seno");
                    Console.WriteLine("6. Cosseno");
                    Console.WriteLine("7. Tangente");
                    Console.WriteLine("8. Raiz Quadrada");
                    Console.WriteLine("9. Potência");
                    Console.WriteLine("10. Sair");

                    int escolha = Convert.ToInt32(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Console.Write("Digite o primeiro número: ");
                            double num1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite o segundo número: ");
                            double num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {num1 + num2}");
                            break;
                        case 2:
                            Console.Write("Digite o primeiro número: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite o segundo número: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {num1 - num2}");
                            break;
                        case 3:
                            Console.Write("Digite o primeiro número: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite o segundo número: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {num1 * num2}");
                            break;
                        case 4:
                            Console.Write("Digite o dividendo: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite o divisor: ");
                            num2 = Convert.ToDouble(Console.ReadLine());

                            if (num2 == 0)
                            {
                                Console.WriteLine("Erro: Divisão por zero.");
                            }
                            else
                            {
                                Console.WriteLine($"Resultado: {num1 / num2}");
                            }
                            break;
                        case 5:
                            Console.Write("Digite o ângulo em graus: ");
                            double angulo = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {Math.Sin(angulo * Math.PI / 180)}");
                            break;
                        case 6:
                            Console.Write("Digite o ângulo em graus: ");
                            angulo = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {Math.Cos(angulo * Math.PI / 180)}");
                            break;
                        case 7:
                            Console.Write("Digite o ângulo em graus: ");
                            angulo = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {Math.Tan(angulo * Math.PI / 180)}");
                            break;
                        case 8:
                            Console.Write("Digite o número: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {Math.Sqrt(num1)}");
                            break;
                        case 9:
                            Console.Write("Digite a base: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite o expoente: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {Math.Pow(num1, num2)}");
                            break;
                        case 10:
                            sair = true;
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
            }
        }
    }
}