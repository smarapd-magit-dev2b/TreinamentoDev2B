using Aula3.Classes;
using Common.Interfaces;
using System;

namespace Aula3.Exercicios.ClasseAbstrataInterface
{
    public class Exercicio1 : IExecute
    {
        public void Execute()
        {
            #region Classe Abstrata
            Console.WriteLine("Classe Abstrata\n");

            ContaCorrenteAbstrata contaCorrenteAbstrata = new ContaCorrenteAbstrata() { 
                Agencia = "21",
                NumeroConta = "32189312"
            };

            string deposito = contaCorrenteAbstrata.Depositar(12);

            Console.WriteLine(deposito);

            string saque =contaCorrenteAbstrata.Sacar(5);

            Console.WriteLine(saque);

            Console.WriteLine(contaCorrenteAbstrata.ImprimeExtrato());

            ContaPoupancaAbstrata contaPoupancaAbstrata = new ContaPoupancaAbstrata()
            {
                Agencia = "12",
                NumeroConta = "154141311"
            };

            deposito = contaPoupancaAbstrata.Depositar(20);

            Console.WriteLine(deposito);

            saque = contaPoupancaAbstrata.Sacar(15);

            Console.WriteLine(saque);

            Console.WriteLine(contaPoupancaAbstrata.ImprimeExtrato());
            #endregion

            #region Interface
            Console.WriteLine("Interface\n");

            ContaCorrenteInterface contaCorrenteInterface = new ContaCorrenteInterface()
            {
                Agencia = "21",
                NumeroConta = "32189312"
            };

            deposito = contaCorrenteInterface.Depositar(12);

            Console.WriteLine(deposito);

            saque = contaCorrenteInterface.Sacar(5);

            Console.WriteLine(saque);

            Console.WriteLine(contaCorrenteInterface.ImprimeExtrato());

            ContaPoupancaInterface contaPoupancaInterface = new ContaPoupancaInterface()
            {
                Agencia = "12",
                NumeroConta = "154141311"
            };

            deposito = contaPoupancaInterface.Depositar(20);

            Console.WriteLine(deposito);

            saque = contaPoupancaInterface.Sacar(15);

            Console.WriteLine(saque);

            Console.WriteLine(contaPoupancaInterface.ImprimeExtrato());
            #endregion
        }
    }
}
