namespace Exercicio18
{
    internal class Program
    {
        //Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Números ÍMPAR entre 100 e 200");
            Console.WriteLine("-----------------------------");

            Console.Write("Os números ÍMPARES são:\n");
            for (int i = 101; i < 200; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
