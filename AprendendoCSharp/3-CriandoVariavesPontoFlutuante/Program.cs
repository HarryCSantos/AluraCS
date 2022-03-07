using System;

namespace _3_CriandoVariavesPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 criando variaveis ponto flutuante");
            //double é um dos três tipos que aceitam numeros não inteiros os outros dois são float e decimal
            
            double salario;
            salario = 1380.50;

            Console.WriteLine("Seu salário é de R$ " + salario);

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            Console.ReadLine();
        }
    }
}
