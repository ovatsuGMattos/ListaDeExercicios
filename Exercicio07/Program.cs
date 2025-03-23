namespace Exercicio07
{
    internal class Program
    {
        // formula Mp = [(N1 x P1) + (N2 x P2)] ÷ (P1 + P2) 
        static void Main(string[] args)
        {
            // Entrada de dados
            Console.Write("Digite a nota da primeira prova: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso da primeira prova: ");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota da segunda prova: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso da segunda prova: ");
            double peso2 = Convert.ToDouble(Console.ReadLine());

            double mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            // Exibe o resultado
            Console.WriteLine($"\nA média ponderada do aluno é: {mediaPonderada:F2}");

            Console.ReadLine();
        }
    }
}
