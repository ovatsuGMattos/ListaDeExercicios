namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // Solicita ao usuário que insira a temperatura em Celsius
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"{celsius}°C é igual a {fahrenheit}°F");

            Console.ReadLine();
        }
    }
}
