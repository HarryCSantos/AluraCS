using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 32;

            decimal salario = 1350.50M;
            //float salario = 1350.00f;

            Console.WriteLine("Sir you are " + idade + " years old and your current salary is $ " + salario);
            Console.ReadLine();
        }
    }
}
