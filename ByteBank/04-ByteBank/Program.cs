using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoMiguel = new ContaCorrente();

            contaDoMiguel.titular = "Miguel";

            Console.WriteLine(contaDoMiguel.saldo);
            contaDoMiguel.Sacar(50);
            Console.WriteLine(contaDoMiguel.saldo);

            Console.ReadLine();
        }
    }
}
