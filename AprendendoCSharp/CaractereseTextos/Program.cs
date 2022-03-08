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

            // o espaço também é considerado um caracter
            char primeiraLetra = 'b';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2020;

            primeiraLetra = (char) (primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia" + 2020;
            Console.WriteLine(titulo);

            Console.ReadLine();
        }
    }
}
