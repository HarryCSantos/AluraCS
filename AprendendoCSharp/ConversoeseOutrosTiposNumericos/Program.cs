using System;

namespace ConversoeseOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            // O int é um tipo de variável que suporta valores de até 32 bits
            int salarioemInteiro;
            salarioemInteiro = (int)salario;

            Console.WriteLine(salarioemInteiro);

            long idade;
            idade = 130000000000;

            short quantidadedeProdutos;
            quantidadedeProdutos = 16000;


        }
    }
}
