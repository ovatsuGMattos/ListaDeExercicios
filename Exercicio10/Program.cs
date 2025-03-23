namespace Exercicio10
{
    internal class Program
    {
        //Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50.
        //Ao final do dia, o dono quer saber quanto arrecadou com avenda dos pães e broas(juntos), e quanto deve guardar numa conta de poupança(10% do total arrecadado).
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("===Cálculo de Arrecadação===");
            Console.WriteLine("-------------------------------------------------");

            Console.Write("Digite a quantidade de pães vendidos: ");
            int quantidadePaes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de broas vendidas: ");
            int quantidadeBroas = Convert.ToInt32(Console.ReadLine());

            double precoPao = 0.12;
            double precoBroa = 1.50;

            double totalPaes = quantidadePaes * precoPao;
            double totalBroas = quantidadeBroas * precoBroa;
            double totalArrecadado = totalPaes + totalBroas;

            double valorPoupanca = totalArrecadado * 0.10;

            Console.WriteLine($"Total arrecadado: R$ {totalArrecadado:F2}");
            Console.WriteLine($"Valor a ser guardado na poupança (10%): R$ {valorPoupanca:F2}");

            Console.ReadLine();
        }
    }
}
