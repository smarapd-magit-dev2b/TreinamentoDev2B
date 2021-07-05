using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.Interfaces
{
    public class ContaCorrenteInterface: IConta
    {
        public int NumeroConta { get; set; }
        public decimal MovimentacoesSaques { get; set; }
        public decimal MovimentacoesDepositos { get; set; }

        public string Agencia { get; set; }

        public ContaCorrenteInterface(int numeroConta, string agencia)
        {
            NumeroConta = numeroConta;
            MovimentacoesSaques = 0;
            MovimentacoesDepositos = 0;
            Agencia = agencia;
        }

        public void ImpreExtrato()
        {
            Console.WriteLine("________( Extrato )________");
            Console.WriteLine($"Numero da conta: {NumeroConta}");
            Console.WriteLine($"Agência: {Agencia}");
            Console.WriteLine($"Valor Saques: {MovimentacoesSaques}");
            Console.WriteLine($"Valor Depósitos: {MovimentacoesDepositos}");
        }

        public void Depositar(decimal valor)
        {
            MovimentacoesDepositos += valor;
        }

        public void Sacar(decimal valor)
        {
            MovimentacoesSaques -= valor;
        }

        public void AplicarTaxaServico(decimal valor)
        {
            MovimentacoesSaques -= valor;
        }

        //public override void ImpreExtrato()
        //{
        //    decimal saldo = 0.0m;
        //    Console.WriteLine("Numero da Conta: " + NumeroConta);
        //    Console.WriteLine("Movimentações de Saques: " + MovimentacoesSaques);
        //    Console.WriteLine("Movimentações de Depósitos:" + MovimentacoesDepositos);
        //    Console.WriteLine("Número da Agência: " + Agencia);
        //    saldo = MovimentacoesDepositos - MovimentacoesSaques;

        //    Console.WriteLine("Saldo Disponível: " + saldo + "R$");
        //}

        //public override void Depositar()
        //{
        //    decimal saldo = MovimentacoesDepositos - MovimentacoesSaques;

        //    Console.WriteLine("Informe o valor a ser depositado(DECIMAL): ");
        //    MovimentacoesDepositos = decimal.Parse(Console.ReadLine());
        //    saldo += MovimentacoesDepositos;
        //    Console.WriteLine("O Novo saldo:" + saldo + "R$");
        //}

        //public override void Sacar()
        //{
        //    decimal saldo = MovimentacoesDepositos - MovimentacoesSaques;

        //    Console.WriteLine("Informe o valor do Saque(DECIMAL): ");
        //    MovimentacoesSaques = decimal.Parse(Console.ReadLine());
        //    saldo -= MovimentacoesSaques;
        //    Console.WriteLine("O Novo saldo: " + saldo + " R$");
        //}

        //public override void AplicarRendimento()
        //{
        //    Console.WriteLine("Opção disponível apenas para contas poupanças");
        //}

        //public override void AplicarTaxaServico()
        //{
        //    decimal saldo = MovimentacoesDepositos - MovimentacoesSaques;
        //    int taxaServico = 0;

        //    Console.WriteLine("Informe a porcentagem da Taxa de serviço");
        //    taxaServico = int.Parse(Console.ReadLine());

        //    saldo = saldo - (saldo * taxaServico) / 100;
        //    Console.WriteLine("O Novo Saldo após a taxa de serviço: " + saldo + " R$");
        //}
    }
}
