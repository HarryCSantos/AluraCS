using System;

namespace ConversoeseOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            // O int é um tipo de variável que suporta valores de até 32 bits
            int salarioemInteiro = (int)salario;

            Console.WriteLine(salarioemInteiro);

            // O long é uma variavel de 64 bits
            long idade = 130000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variavel de 16 bits
            short quantidadedeProdutos = 16000;
            Console.WriteLine(quantidadedeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);



        }
    }
}
