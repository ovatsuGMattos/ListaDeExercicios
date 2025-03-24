namespace Exercicio20
{
    internal class Program
    {

        //Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N.
        //Mostre a tabuada na forma:● 0 x N = 0,
        //● 1 x N = 1N,
        //● 2 x N = 2N,
        //.
        //.
        //.
        //● 10 x N = 10N.
        static void Main(string[] args)
        {
            Console.WriteLine("------------");
            Console.WriteLine("Tábuada do N");
            Console.WriteLine("------------");

            Console.WriteLine("Digite o valor de N entre 1 e 10");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N < 1 || N > 10)
            {
                Console.WriteLine("Valor inválido, digite um numero entre 1 e 10");
            }
            else
            {
                for (int i = 0; i <=10; i++)
                {
                    int resultado = i * N;
                    Console.WriteLine($"{i} x {N} = {resultado}");
                } 

                Console.ReadLine();
            }
        }
    }
}
