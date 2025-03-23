namespace Exercicio09
{
    internal class Program
    {
        //A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.
        // Área = Largura×Comprimento
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("=== Cálculo da Área do Terreno ===");
            Console.WriteLine("--------------------------------");

            Console.Write("Digite a largura do terreno (em metros): ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o comprimento do terreno (em metros): ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            double area = largura * comprimento;

            Console.WriteLine($"\nA área do terreno é: {area} m²");

            Console.ReadLine();
        }
    }
}
