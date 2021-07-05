using Aula04.ClassesAbstratas;
using Aula04.Interfaces;
using System;

namespace Aula04
{
    public class InterfacesClassesAbstratas
    {
        public void Execute()
        {
            //Exercicio1Abstrata();
            //Exercicio2Abstrata();

            //Exercicio1Interface();
            //Exercicio2Interface();

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


        static void exercicio2abstrata()
        {
            ClassesAbstratas.Adicao adicao = new ClassesAbstratas.Adicao();
            ClassesAbstratas.Divisao divisao = new ClassesAbstratas.Divisao();
            ClassesAbstratas.Multiplicacao multiplicacao = new ClassesAbstratas.Multiplicacao();
            ClassesAbstratas.Subtracao subtracao = new ClassesAbstratas.Subtracao();

            subtracao.Calcular();
            multiplicacao.Calcular();
            divisao.Calcular();
            adicao.Calcular();
        }

        static void exercicio1interface()
        {
            Console.WriteLine("______________( Conta Poupança )______________");
            ContaPoupancaInterface contaPoupanca = new ContaPoupancaInterface(11, "1212-12");
            contaPoupanca.ImpreExtrato();
            contaPoupanca.Depositar(1500m);
            contaPoupanca.Sacar(500m);
            contaPoupanca.AplicarRendimento(20);
            contaPoupanca.ImpreExtrato();

            Console.WriteLine("______________( Conta Corrente )______________");
            ContaCorrenteInterface contaCorrente = new ContaCorrenteInterface(11, "1212-12");
            contaCorrente.ImpreExtrato();
            contaCorrente.Depositar(1500m);
            contaCorrente.Sacar(500m);
            contaCorrente.AplicarTaxaServico(20);
            contaCorrente.ImpreExtrato();
        }

        static void Exercicio2Interface()
        {
            
            Console.WriteLine("Informe o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Interfaces.Subtracao subtracao = new Interfaces.Subtracao(valor1, valor2);
            Console.WriteLine("A subtração é " + subtracao.Calcular());

            Interfaces.Adicao adicao = new Interfaces.Adicao(valor1, valor2);
            Console.WriteLine("A subtração é " + adicao.Calcular());

            Interfaces.Multiplicacao multiplicacao = new Interfaces.Multiplicacao(valor1, valor2);
            Console.WriteLine("A subtração é " + multiplicacao.Calcular());

            Interfaces.Divisao divisao = new Interfaces.Divisao(valor1, valor2);
            Console.WriteLine("A subtração é " + divisao.Calcular());

        }
    }
}
