namespace Exercicio03
{
    internal class Program
    {
        //Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem. O programa deve solicitar ao usuário:
        //● A quilometragem inicial do veículo no início da viagem.
        //● A quilometragem final ao término da viagem.
        //● A quantidade de combustível consumida durante a viagem(em litros).
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a quilometragem inicial:");
            double kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem final:");
            double kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o consumo de combustivel após a viagem (litros): ");
            double consumoCombustivel = Convert.ToDouble(Console.ReadLine());

            double distanciaPercorrida = kmFinal - kmInicial;

            double consumoPorKm = distanciaPercorrida / consumoCombustivel;

            Console.WriteLine($"O consumo de combustivel durante o percurso foi de ~ {consumoPorKm} km/l");



            Console.ReadLine();
        }
    }
}
