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

            bool resultadodoSaque = contaDoMiguel.Sacar(500);

            contaDoMiguel.Sacar(500);
            Console.WriteLine(contaDoMiguel.saldo);
            Console.WriteLine(resultadodoSaque);

            contaDoMiguel.Depositar(1000);
            Console.WriteLine(contaDoMiguel.saldo);

            Console.ReadLine();
        }
    }
}
