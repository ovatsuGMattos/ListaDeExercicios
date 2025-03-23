using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;

namespace Exercicio11
{
    //Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
    //Considere sempre anos completos, e que um ano possui 365 dias.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("=== Calculadora de Dias de Vida ===");
            Console.WriteLine("------------------------------------");

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine()!;

            Console.Write("Digite a sua idade (anos completos): ");
            int idade = Convert.ToInt32(Console.ReadLine());

            int diasDeVida = idade * 365;

            // Exibe o resultado
            Console.WriteLine($"\n{nome.ToUpper()}, VOCÊ JÁ VIVEU {diasDeVida} DIAS.");

            Console.ReadLine();
        }
    }
}
