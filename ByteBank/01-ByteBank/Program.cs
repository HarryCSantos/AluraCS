using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaDaGabriela = new ContaCorrente();

            ContaDaGabriela.titular = "Gabriela";
            ContaDaGabriela.agencia = 863;
            ContaDaGabriela.numero = 863452;
            ContaDaGabriela.saldo = 100;

            Console.WriteLine(ContaDaGabriela.titular);
            

            Console.ReadLine();
        }
    }
}
