namespace Exercicio16
{
    internal class Program
    {

        //Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
        static void Main(string[] args)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Verifique se o número é ÍMPAR ou PAR!");
            Console.WriteLine("---------------");

            Console.WriteLine("Digite um número inteiro");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0) //% = se o número é divisivel por 2, consequentemente, se for, é par.
            {
                Console.WriteLine("O número é PAR");
            }
            else
            {
                Console.WriteLine("O número é ÍMPAR");
            }

            Console.ReadLine();
        }
    }
}
