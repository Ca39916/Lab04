using System;

namespace Laboratorio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("-----exercício 2 -----");
            ContaCorrente minhaConta = new ContaCorrente(340);
            Console.WriteLine("Saldo da conta R$ " + minhaConta.Saldo); 

            minhaConta.Depositar(100); 
            Console.WriteLine("Valor do deposito R$ " + minhaConta.Saldo);
            
            minhaConta.Sacar(50);
            Console.WriteLine("Valor do saque R$ " + minhaConta.Saldo);
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("-----exercício 4.1 -----");
            ContaCorrente conta = new ContaCorrente("Camila Rezende");
            conta.Depositar(100);
            conta.Depositar(100);
            conta.Depositar(100);
            conta.Sacar(200);
            Console.WriteLine("Valor média da conta R$ " + conta.saldomediaContaT);
            Console.ReadKey();

        }
    }
}
