namespace Exercicio08
{
    internal class Program
    {
        //Crie um programa para verificar se um número é primo.
        static void Main(string[] args)
        {
            // Entrada do número
            Console.Write("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool ehPrimo = true;

            if (numero <= 1)
            {
                ehPrimo = false; 
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        ehPrimo = false;
                        break;
                    }
                }
            }

            if (ehPrimo)
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }

            Console.ReadLine();
        }
    }
}
