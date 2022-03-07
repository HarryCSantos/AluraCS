using System;

namespace ConversoeseOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            //Double - adimite valores com ponto e também admite números inteiros;
            double salario = 1200.50;

            /*int só admite números inteiros
            O int é um tipo de variável que suporta valores de até 32 bits
            Para especificar que o double será int colocamos entre parêntes como está no exemplo abaixo
            O nome dessa operação é conhecido como "casting". Dessa forma deixamos claro para o compilador o que estamos fazendo.
            */
            int salarioemInteiro = (int)salario;

            Console.WriteLine(salarioemInteiro);

            // O long é uma variavel de 64 bits
            // O tipo "long" não é tão utilizado justamente por ocupar mais espaço na memória. Por isso, o tipo "int" ainda é o mais utilizado.
            long idade = 130000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variavel de 16 bits
            short quantidadedeProdutos = 16000;
            Console.WriteLine(quantidadedeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine(); 



        }
    }
}
