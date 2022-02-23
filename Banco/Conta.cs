using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Conta
    {
        private int id;
        private double saldo;
        private int agencia;
        private Titular titular;




        public Conta()
        {

        }
        public Conta(int id, double saldo, int agencia, Titular titular)
        {
            this.id = id;
            this.saldo = saldo;
            this.agencia = agencia;
            this.titular = titular;
        }

        public void saque(double valor)
        {
               if(valor <= this.saldo && valor > 0)
            {
                this.saldo -= valor;
            }
               else if(valor <= this.saldo)
            {
                Console.WriteLine("Você não possui saldo suficiente para esta operação.");
            }
               else
            {
                Console.WriteLine("Valor inválido");
            }
        }

        public void depositar(double valor)
        {
            if(valor > 0)
            {
                this.saldo += valor;
            } else
            {
                Console.WriteLine("Valor inválido");
            }
        }

        public void transferir(Conta conta, double valor)
        {
            if(valor <= this.saldo && valor > 0)
            {
                this.saque(valor);
                conta.depositar(valor);
            }
            else if (valor <= this.saldo)
            {
                Console.WriteLine("Você não possui saldo suficiente para esta operação.");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }

        public int getId()
        {
            return this.id;
        }

        public Titular getTitular()
        {
            return this.titular;
        }
    }
}
