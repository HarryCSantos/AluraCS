using System;

namespace ConversoeseOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            //Double - adimite valores com ponto e também admite números inteiros;
            double salario = 1270.50;
            //int valor = salario;// Esse exemplo de código não compila uma vez que estamos tentando atribuir uma váriável "double" dentro de uma variável "int"
            // Existe uma forma de fazer com que esse código compile. Para isso usaremos o que chamamos de CASTING que é o exemplo abaixo
            
            int valor = (int)salario; // Quando fazemos o CASTING estamos pedindo ao C# que ache uma forma de transformar o valor ao lado direito do (int), no nosso caso, a variável salario, em inteiro. Dessa forma o C# transformará em "double" para "int"
            //Repare que o CASTING é usado colocando a variável int em parênteses

            /*int só admite números inteiros
            O int é um tipo de variável que suporta valores de até 32 bits
            Para especificar que o double será int colocamos entre parêntes como está no exemplo abaixo
            O nome dessa operação é conhecido como "casting". Dessa forma deixamos claro para o compilador o que estamos fazendo.
            */

            float pontoFlutuante = 3.17f;
            Console.WriteLine(pontoFlutuante);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine(total);

            Console.WriteLine(valor);

            Console.WriteLine(salario); 



            // O long é uma variavel de 64 bits
            // O tipo "long" não é tão utilizado justamente por ocupar mais espaço na memória. Por isso, o tipo "int" ainda é o mais utilizado.
            long idade = 130000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variavel de 16 bits
            // A variável "short" é de 16 bits, ou seja, o valor NÃO pode ser MAIOR que 16 mil.
            short quantidadedeProdutos = 16000;
            Console.WriteLine(quantidadedeProdutos); // As sinalizações verdes são warnings ou seja avisos de que declaramos as variáveis e, depois, não as utilizamos por isso a declaramos, incluindo o "Console.WriteLine().

            // A difereça do float para o tipo double é que o float tem uma precisão curta de números suportados nas casas decimais ao contrário do double, que suporta uma precisão maior.
            // O C# costuma interpretar um número com ponto flutuante como um "double" - o que significa que estamos tentando colocar esse valor dentro de um float. 
            // Para sermos bem sucedidos nesta tarefa, teremos que adicionar um sufixo "f", justamente por ser incomum o uso do float.
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine(); 



        }
    }
}
