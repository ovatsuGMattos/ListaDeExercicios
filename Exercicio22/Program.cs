namespace Exercicio22
{
    internal class Program
    {

        //A sequência de Fibonacci é uma sequência numérica em que cada número é a soma dos dois anteriores, começando por 1 e 1.
        //Fórmula de Fibonacci= fn=fn−1+fn−2

        //Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Sequência de Fibonacci");
            Console.WriteLine("----------------------");

            Console.Write("Digite um número para o limite da sequência de Fibonacci: ");
            int limite = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1;

            if (limite >= 0)
            {
                Console.WriteLine("Sequência de Fibonacci até " + limite + ":");

                if (limite >= 0) Console.Write(a + "");
                if (limite >= 1) Console.Write(b + "");

                while (true)
                {
                    int proximo = a + b;
                    if (proximo > limite)
                        break;

                    Console.Write(proximo + "");
                    a = b;
                    b = proximo;
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Por favor, insira um número maior ou igual a 0.");
            }

            Console.ReadLine();
        }
    }
}
