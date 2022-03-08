using System;

namespace CaractereseTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            // character
            /*Quando trabalhamos com caracteres dentro da variável, no caso, 
            * colocaremos 'a'. Neste caso, inserimos a letra entre aspas simples,
            * isto porque existe diferenças entre um caractere e um texto.*/

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) (primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            Console.ReadLine();
        }
    }
}
