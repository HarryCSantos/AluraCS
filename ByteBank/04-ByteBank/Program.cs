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


            ContaCorrente contadaMaria = new ContaCorrente();

            contadaMaria.titular = "Maria";

            contaDoMiguel.Transferir(300, contadaMaria);

            Console.WriteLine("Saldo do Miguel: " + contaDoMiguel);
            Console.WriteLine("Saldo da Maria: " + contadaMaria);

            bool resultadoTranferencia = contaDoMiguel.Transferir(200, contadaMaria);

            Console.WriteLine("Resultado transferência: " + resultadoTranferencia);

            Console.WriteLine("Saldo do Miguel: " + contaDoMiguel.saldo);
            Console.WriteLine("Saldo da Maria: " + contadaMaria.saldo);


            Console.ReadLine();
        }
    }
}
