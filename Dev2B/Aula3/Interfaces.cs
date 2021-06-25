using Aula3.Exercicio2.Domain;
using Aula3.Exercicio2.Domain.Interfaces;
using Aula3.Exercicio4.Classes;
using System;

namespace Aula3
{
    public class Interfaces
    {
        public void Execute()
        {
            Exercicio1_Classe();
            Exercicio1_Interface();
            Exercicio2_Classe();
            Exercicio2_Interface();
        }

        private void Exercicio1_Classe()
        {
            Console.WriteLine("\n\nConta Poupanca\n");
            ContaPoupanca contaPoupanca = new ContaPoupanca(1, "541-5");
            contaPoupanca.ImpreExtrato();
            contaPoupanca.Depositar(100m);
            contaPoupanca.Depositar(200m);
            contaPoupanca.Sacar(100m);
            contaPoupanca.ImpreExtrato();
            contaPoupanca.AplicarRendimento(5);
            contaPoupanca.ImpreExtrato();

            Console.WriteLine("\n\nConta Corrente\n");
            ContaCorrente contaCorrente = new ContaCorrente(1, "5512-5");
            contaCorrente.ImpreExtrato();
            contaCorrente.Depositar(200m);
            contaCorrente.Depositar(300m);
            contaCorrente.Sacar(300m);
            contaCorrente.ImpreExtrato();
            contaCorrente.AplicarTaxaServico(50);
            contaCorrente.ImpreExtrato();
        }

        private void Exercicio1_Interface()
        {
            Console.WriteLine("\n\nConta Poupanca`com interface\n");
            ContaPoupancaInterface contaPoupanca = new ContaPoupancaInterface(1, "5421-5");
            contaPoupanca.ImpreExtrato();
            contaPoupanca.Depositar(1300m);
            contaPoupanca.Depositar(2300m);
            contaPoupanca.Sacar(1300m);
            contaPoupanca.ImpreExtrato();
            contaPoupanca.AplicarRendimento(55);
            contaPoupanca.ImpreExtrato();

            Console.WriteLine("\n\nConta Corrente com interface\n");
            ContaCorrenteInterface contaCorrente = new ContaCorrenteInterface(1, "55152-5");
            contaCorrente.ImpreExtrato();
            contaCorrente.Depositar(2200m);
            contaCorrente.Depositar(3200m);
            contaCorrente.Sacar(3200m);
            contaCorrente.ImpreExtrato();
            contaCorrente.AplicarTaxaServico(501);
            contaCorrente.ImpreExtrato();
        }

        private void Exercicio2_Classe()
        {
            SomaA soma = new SomaA(5, 6);
            Console.WriteLine(soma.Calcular());

            DividirA dividir = new DividirA(6, 3);
            Console.WriteLine(dividir.Calcular());

            MultiplicarA multiplicar = new MultiplicarA(7, 6);
            Console.WriteLine(multiplicar.Calcular());

            SubtrairA subtrair = new SubtrairA(6, 9);
            Console.WriteLine(subtrair.Calcular());
        }

        private void Exercicio2_Interface()
        {
            Soma soma = new Soma();
            Console.WriteLine(soma.Calcular(5, 5));

            Subtrair subtrair = new Subtrair();
            Console.WriteLine(subtrair.Calcular(5, 5));

            Multiplicar multiplicar = new Multiplicar();
            Console.WriteLine(multiplicar.Calcular(5, 5));

            Dividir dividir = new Dividir();
            Console.WriteLine(dividir.Calcular(5, 5));


        }




    }
}
