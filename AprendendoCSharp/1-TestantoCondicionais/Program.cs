using System;

namespace _1_TestantoCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais");

            int idade = 17;
            int quantidadePessoas = 3;
            
            if (idade >= 18)
            {
                Console.WriteLine("Você tem mais que 18 anos");
                Console.WriteLine("Seja bem vindo!");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Você não tem 18 anos, mas pode entrar, "+ "pois está acompanhado.");
                }
                else
                {
                    Console.WriteLine("Infelizmente você não pode entrar pois é menor de idade e não está acompanhado.");
                }
            }

            Console.ReadLine();

        }
    }
}
