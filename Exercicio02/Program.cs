namespace Exercicio02
{
    internal class Program
    {

        //Crie um programa para calcular o volume de um Cilindro
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio do cilindro:");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do cilindro:");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI* Math.Pow(raio, 2) * altura;

            Console.WriteLine($"O volume do cilindro é: {volume} cm³.");

            Console.ReadLine();
        }
    }
}
