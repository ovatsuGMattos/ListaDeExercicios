namespace Exercicio15
{
    internal class Program
    {
        //Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:● IMC em adultos Condição
        //Abaixo de 18,5
        //Abaixo do peso
        //Entre 18,5 e 25 Peso normal
        //Entre 25 e 30
        //Acima do peso
        //Acima de 30 obeso
        // formula: IMC = PESO/ALTURA²
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("=== Cálculo do IMC ===");
            Console.WriteLine("----------------------");

            Console.Write("Digite o peso (em kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"IMC: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Condição: Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Condição: Acima do peso");
            }
            else
            {
                Console.WriteLine("Condição: Obeso");
            }

            Console.ReadLine();
        }
    }
}
