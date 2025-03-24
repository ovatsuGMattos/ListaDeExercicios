using System.Drawing;

namespace Exercicio21
{
    internal class Program
    {
        //Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.
        //a.Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
        //b.Pesquise sobre “fatorial”
        //Fórmula= n!=n×(n−1)×(n−2)×⋯×1
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Cálculo Fatorial ");
            Console.WriteLine("-----------------");

            Console.WriteLine("Digite o valor de A");
            int A = Convert.ToInt32(Console.ReadLine());

            if (A < 0)
            {
                Console.WriteLine("Não existe fatorial negativo");
            }
            else
            {
                int resultado = 1;
                string sequencia = "";

                for (int i = A; i > 0; i--)
                { 
                    resultado *= i;

                    if (i == 1)
                    {
                        sequencia += i + " = ";
                    }
                    else
                    {
                        sequencia += i + " x ";
                    }

                    Console.WriteLine($"{sequencia}{resultado}");
                }
                Console.ReadLine();
            }               
        }
    }
}
