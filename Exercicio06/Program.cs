namespace Exercicio06
{
    internal class Program
    {
        //Crie um programa para calcular a média harmônica das notas de um Aluno
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de notas: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            double[] notas = new double[quantidade];
            double somaInversos = 0;

            // Leitura das notas
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite a nota {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());

                if (notas[i] != 0)
                {
                    somaInversos += 1 / notas[i];
                }
                else
                {
                    Console.WriteLine("Nota não pode ser zero na média harmônica!");
                    return;
                }
            }

            double mediaHarmonica = quantidade / somaInversos;

            Console.WriteLine($"\nA média harmônica das notas é: {mediaHarmonica:F2}");

            Console.ReadLine();
        }
    }
}
