using Aula04.ClassesAbstratas;
using System;

namespace Aula04
{
    public class InterfacesClassesAbstratas
    {
        public void Execute()
        {
            //Exercicio1Abstrata();
            //Exercicio2Abstrata();

            Exercicio1Interface();
            Exercicio2Interface();

        }

        static void Exercicio1Abstrata()
        {
           
            ContaPoupanca contaPoupanca = new ContaPoupanca();
            ContaCorrente contaCorrente = new ContaCorrente();

            Console.WriteLine("==============( Informe as informações da Conta Corrente )==============");
            Console.WriteLine("");
            Console.WriteLine("Informe o Número da conta Corrente: ");
            contaCorrente.NumeroConta = Console.ReadLine();

            Console.WriteLine("Movimentações Saques(DECIMAL): ");
            contaCorrente.MovimentacoesSaques = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Movimentações Depositos(DECIMAL): ");
            contaCorrente.MovimentacoesDepositos = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Agência: ");
            contaCorrente.Agencia = Console.ReadLine();

            Console.WriteLine("");
            contaCorrente.ImpreExtrato();
            contaCorrente.Depositar();
            contaCorrente.Sacar();
            contaCorrente.AplicarTaxaServico();
            contaCorrente.AplicarRendimento();//Não Disponível


            Console.WriteLine("==============( Informe as informações da Conta Poupança )==============");
            Console.WriteLine("");
            Console.WriteLine("Informe o Número da conta Poupança: ");
            contaPoupanca.NumeroConta = Console.ReadLine();

            Console.WriteLine("Movimentações Saques(DECIMAL): ");
            contaPoupanca.MovimentacoesSaques = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Movimentações Depositos(DECIMAL): ");
            contaPoupanca.MovimentacoesDepositos = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Agência: ");
            contaPoupanca.Agencia = Console.ReadLine();

            Console.WriteLine("");
            contaPoupanca.ImpreExtrato();
            contaPoupanca.Depositar();
            contaPoupanca.Sacar();
            contaPoupanca.AplicarTaxaServico();//Não Disponível
            contaPoupanca.AplicarRendimento();
        }


        static void Exercicio2Abstrata()
        {
            Adicao adicao = new();
            Divisao divisao = new();
            Multiplicacao multiplicacao = new();
            Subtracao subtracao = new();

            subtracao.Calcular();
            multiplicacao.Calcular();
            divisao.Calcular();
            adicao.Calcular();
        }

        static void Exercicio1Interface()
        {
            ContaCorrente contaCorrente = new();
            ContaPoupanca contaPoupanca = new();

            Console.WriteLine("==============( Informe as informações da Conta Corrente )==============");
            Console.WriteLine("");
            Console.WriteLine("Informe o Número da conta Corrente: ");
            contaCorrente.NumeroConta = Console.ReadLine();

            Console.WriteLine("Movimentações Saques(DECIMAL): ");
            contaCorrente.MovimentacoesSaques = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Movimentações Depositos(DECIMAL): ");
            contaCorrente.MovimentacoesDepositos = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Agência: ");
            contaCorrente.Agencia = Console.ReadLine();

            Console.WriteLine("");
            contaCorrente.ImpreExtrato();
            contaCorrente.Depositar();
            contaCorrente.Sacar();
            contaCorrente.AplicarTaxaServico();
            contaCorrente.AplicarRendimento();//Não Disponível


            Console.WriteLine("==============( Informe as informações da Conta Poupança )==============");
            Console.WriteLine("");
            Console.WriteLine("Informe o Número da conta Poupança: ");
            contaPoupanca.NumeroConta = Console.ReadLine();

            Console.WriteLine("Movimentações Saques(DECIMAL): ");
            contaPoupanca.MovimentacoesSaques = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Movimentações Depositos(DECIMAL): ");
            contaPoupanca.MovimentacoesDepositos = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Agência: ");
            contaPoupanca.Agencia = Console.ReadLine();

            Console.WriteLine("");
            contaPoupanca.ImpreExtrato();
            contaPoupanca.Depositar();
            contaPoupanca.Sacar();
            contaPoupanca.AplicarTaxaServico();//Não Disponível
            contaPoupanca.AplicarRendimento();
        }
    }
}
