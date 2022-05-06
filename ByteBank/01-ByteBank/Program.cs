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

            Console.WriteLine("Titular: " + ContaDaGabriela.titular);
            Console.WriteLine("Agência: " + ContaDaGabriela.agencia);
            Console.WriteLine("Número: " + ContaDaGabriela.numero);
            Console.WriteLine("Saldo " + ContaDaGabriela.saldo);

            ContaDaGabriela.saldo += 200;
            Console.WriteLine("Saldo: " + ContaDaGabriela.saldo);




            Console.ReadLine();
        }
    }
}
