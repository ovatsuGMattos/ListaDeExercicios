namespace Exercicio13
{
    internal class Program
    {
        //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("=== Verificação de Soma ===");
            Console.WriteLine("---------------------------");

            Console.Write("Digite o valor de A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int C = Convert.ToInt32(Console.ReadLine());

            if (A + B < C)
            {
                Console.WriteLine("\nA soma de A + B é menor que C.");
            }
            else
            {
                Console.WriteLine("\nA soma de A + B NÃO é menor que C.");
            }

            Console.ReadLine();
        }
    }
}
