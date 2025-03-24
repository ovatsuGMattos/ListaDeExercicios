namespace Exercicio12
{
    internal class Program
    {
        //Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de impostos.
        //Imprima o salário inicial, o salário com o aumento e o salário final.
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("=== Calculo de Aumento e Impostos ===");
            Console.WriteLine("-------------------------------------");

            Console.Write("Digite o salário do funcionário: R$ ");
            double salarioInicial = Convert.ToDouble(Console.ReadLine());

            double salarioComAumento = salarioInicial * 1.15;

            double salarioFinal = salarioComAumento * 0.92;

            Console.WriteLine($"\nSalário inicial: R$ {salarioInicial:F2}");
            Console.WriteLine($"Salário com aumento de 15%: R$ {salarioComAumento:F2}");
            Console.WriteLine($"Salário final após desconto de 8% de impostos: R$ {salarioFinal:F2}");

            Console.ReadLine();
        }
    }    
}
