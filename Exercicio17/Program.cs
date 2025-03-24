namespace Exercicio17
{
    internal class Program
    {

        //Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B.
        //Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando valores");

            Console.WriteLine("Digite o valor de A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            //valor a ser descoberto
            int C; 

            if (A == B)
            {
                C = A + B;
            }
            else
            {
                C = A * B;
            }

            Console.WriteLine($"O resultado é {C}");

            Console.ReadLine();
        }
    }
}
