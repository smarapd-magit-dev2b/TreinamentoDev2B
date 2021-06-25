using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3.Exercicio4.Classes
{
    public abstract class Conta
    {
        
        public int NumeroConta { get; set; }
        public decimal MovimentacoesSaques { get; private set; }
        public decimal MovimentacoesDepositos { get; private set; }
        public string Agencia { get; set; }

        protected Conta(int numeroConta, string agencia)
        {
            
            NumeroConta = numeroConta;
            MovimentacoesSaques = 0;
            MovimentacoesDepositos = 0;
            Agencia = agencia;
        }

        public void ImpreExtrato()
        {
            Console.WriteLine("======= Extrato =======");
            Console.WriteLine($"Numero da conta: {NumeroConta}");
            Console.WriteLine($"Agencia: {NumeroConta}");
            Console.WriteLine($"Movimentacoes de saque: {MovimentacoesSaques}");
            Console.WriteLine($"Movimentacoes de deposito: {MovimentacoesDepositos}");
        }
        public void Depositar(decimal valor)
        {
            MovimentacoesDepositos += valor;
        }
        public void Sacar(decimal valor)
        {
            MovimentacoesSaques -= valor;
        }
    }
}
