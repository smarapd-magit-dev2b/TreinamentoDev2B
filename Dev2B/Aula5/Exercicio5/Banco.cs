using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula5.Exercicio5
{
    class Banco
    {
        public List<Conta> ListaContas { get; set; }

        public void CadastrarConta()
        {
            Console.WriteLine("Digite o numero da conta");
            string numero = Console.ReadLine();
            decimal saldo = 0;
            Console.WriteLine("A conta é conta corrente especial ? S ou N:");
            string vericaEspecial = Console.ReadLine();
            bool isEspecial;
            if (vericaEspecial == "s")
            {
                isEspecial = true;
            }
            else
            {
                isEspecial = false;
            }
            decimal limite = 500;
            ListaContas.Add(new Conta(numero, saldo, isEspecial, limite));
        }
        public void ExcluirConta()
        {
            Console.WriteLine("Qual o numero da conta que deseja excluir? ");
            var numero = Console.ReadLine();
            var ContaExcluir = ListaContas.Where(x => x.Numero == numero).FirstOrDefault();
            ListaContas.Remove(ContaExcluir);

        }
        public void Saque()
        {
            Console.WriteLine("Qual o numero da conta que deseja sacar? ");
            var contaSaque = Console.ReadLine();
            var conta = ListaContas.Where(x => x.Numero == contaSaque).FirstOrDefault();
            Console.WriteLine("Quanto deseja sacar? ");
            decimal saque = Convert.ToDecimal(Console.ReadLine());
            if (conta.Saldo > 0 && saque <= conta.Saldo && saque <= conta.Limite)
            {
                conta.Saldo = conta.Saldo - saque;
                saque = -saque;
                conta.ListaMovimentacao.Add(new Movimentacao()
                {
                    Descricao = "Saque",
                    Valor = saque.ToString("C"),
                    IsCredito = false
                });
            }
        }
        public void Deposito()
        {
            Console.WriteLine("Qual o numero da conta que deseja depositar? ");
            var contaDeposito = Console.ReadLine();
            var conta = ListaContas.Where(x => x.Numero == contaDeposito).FirstOrDefault();
            Console.WriteLine("Quanto deseja depositar? ");
            decimal deposito = Convert.ToDecimal(Console.ReadLine());
            if (deposito != null && deposito > 0)
            {
                conta.Saldo = conta.Saldo + deposito;
                conta.ListaMovimentacao.Add(new Movimentacao
                {
                    Descricao = "Deposito",
                    Valor = deposito.ToString("C"),
                    IsCredito = true
                });
            }
        }
        public void EmitirSaldo()
        {
            Console.WriteLine("Qual o numero da conta que deseja verificar o saldo? ");
            var contaSaldo = Console.ReadLine();
            var conta = ListaContas.Where(x => x.Numero == contaSaldo).FirstOrDefault();
            Console.WriteLine(conta.Saldo);
        }
        public void EmitirExtrato()
        {
            Console.WriteLine("Qual o numero da conta que deseja verificar o extrato? ");
            var contaExtrato = Console.ReadLine();
            var conta = ListaContas.Where(x => x.Numero == contaExtrato).FirstOrDefault();
            Console.WriteLine(conta.ListaMovimentacao.ToString());
        }
        public void Transferencia()
        {
            Console.WriteLine("Qual o numero da conta que deseja retirar o dinheiro? ");
            string contaTransferenciaSaque = Console.ReadLine();
            var contaSaque = ListaContas.Where(x => x.Numero == contaTransferenciaSaque).FirstOrDefault();
            decimal saque = Convert.ToDecimal(Console.ReadLine());
            if (contaSaque.Saldo > 0 && saque <= contaSaque.Saldo && saque <= contaSaque.Limite)
            {
                contaSaque.Saldo = contaSaque.Saldo - saque;
                saque = -saque;
                contaSaque.ListaMovimentacao.Add(new Movimentacao()
                {
                    Descricao = "Transferencia",
                    Valor = saque.ToString("C"),
                    IsCredito = false
                });
                Console.WriteLine("Qual o numero da conta que deseja transferir o dinheiro? ");
                string contaTransferenciaDeposito = Console.ReadLine();
                var contaDeposito = ListaContas.Where(x => x.Numero == contaTransferenciaDeposito).FirstOrDefault();
                decimal deposito = -saque;
                if (deposito != null && deposito > 0)
                {
                    contaDeposito.Saldo = contaDeposito.Saldo + deposito;
                    contaDeposito.ListaMovimentacao.Add(new Movimentacao
                    {
                        Descricao = "Recebendo Transferencia",
                        Valor = deposito.ToString("C"),
                        IsCredito = true
                    });
                }
            }

            
        }
    }
}
