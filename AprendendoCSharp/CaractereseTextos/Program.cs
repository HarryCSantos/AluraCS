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


            char letra = 'a';


            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            // Agora é possível criar uma string única com várias linhas, sem concatenação. Mas a impressão não ficará perfeita.
            // No momento em que usamos @, o compilador vai considerar tudo entre as aspas e o texto, inclusive o espaço. Para solucionar o tema, posso remover os espaços entre os cursos.
            // O @ permite a impressão multilinha com uma unica string
            string curso = "Alura Cursos de tecnologia " + 2020;
            string cursosProgramacao = 
@" - .NET   
 - Java
 - Javascript";
            Console.WriteLine(cursosProgramacao);


            primeiraLetra = (char) (primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia" + 2020;
            Console.WriteLine(titulo);

            Console.ReadLine();
        }
    }
}
