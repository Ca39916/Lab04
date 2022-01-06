using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    internal class ContaCorrente
    { 
        
        private decimal saldo;
        public void Depositar(decimal val)
        {
            saldo = saldo + val;
            contador++; //contator serve para contar quantas vezes foram feitas as transações
            acumulador = acumulador + saldo; //soma todos os saldos após as transções
            saldomediaContaT = acumulador / contador; //media do saldo final após as transações

        }
        public void Sacar(decimal val)
        {
            saldo = saldo - val;
            contador++; //contator serve para contar quantas vezes foram feitas as transações
            acumulador = acumulador + saldo; //soma todos os saldos após as transções
            saldomediaContaT = acumulador / contador; //media do saldo final após as transações
        }
        public decimal Saldo
        {
            get { return saldo; }
        }
        public ContaCorrente(decimal val)
        {
            saldo = val;
        }
        
        public DateTime dataAberturaConta { get; set; } //PROPRIEDADES DE ACESSO get = pegar o valor da vaariavel
                                                        //set = grava o valor da variável 
        public string nomeTitular { get; set; }

        public decimal saldomediaContaT { get; set; }
        public int contador { get; set; }
        public decimal acumulador { get; set; }

        public ContaCorrente(string v1)
        {
            nomeTitular = v1;
            dataAberturaConta = DateTime.Now;
            contador = 0; //contator serve para contar quantas vezes foram feitas as transações
            acumulador = 0;
        }

    }
}
