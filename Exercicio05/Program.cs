namespace Exercicio05
{
    internal class Program
    {
        //Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de vendas
        //A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.
        static void Main(string[] args)
        {

            Console.Write("Digite o salário base do vendedor: R$ ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o total de vendas: R$ ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual de comissão (%): ");
            double percentualComissao = Convert.ToDouble(Console.ReadLine());

            double valorComissao = (percentualComissao / 100) * totalVendas;

            double salarioTotal = salarioBase + valorComissao;

            Console.WriteLine($"\nComissão: R$ {valorComissao:F2}");
            Console.WriteLine($"Salário total do vendedor: R$ {salarioTotal:F2}");

            Console.ReadLine();
        }
    }
}
