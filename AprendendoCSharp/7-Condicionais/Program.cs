using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 18;

            if (idadeJoao >= 18)
            {

                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");
            }
            else
            {
                Console.WriteLine("João não possui mais de 18 anos de idade. Portanto não pode entrar");
            }

            Console.ReadLine();

        }
    }
}
