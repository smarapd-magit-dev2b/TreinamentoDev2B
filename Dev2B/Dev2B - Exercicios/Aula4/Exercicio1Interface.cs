using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4
{
    public class Exercicio1Interface
    {
        public void Execute()
        {
            Exercicio1();
        }

        private void Exercicio1()
        {
            Subtracao subtracao = new Subtracao();
            Soma soma = new Soma();
            Divisao divisao = new Divisao();
            Multiplicacao multiplicacao = new Multiplicacao();

            Decimal vlr1, vlr2;

            Console.WriteLine("Informe o valor 1: ");
            vlr1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe o valor 2: ");
            vlr2 = Convert.ToDecimal(Console.ReadLine());

            subtracao.Valor1 = vlr1;
            subtracao.Valor2 = vlr2;
            soma.Valor1 = vlr1;
            soma.Valor2 = vlr2;
            multiplicacao.Valor1 = vlr1;
            multiplicacao.Valor2 = vlr2;
            divisao.Valor1 = vlr1;
            divisao.Valor2 = vlr2;

            Console.WriteLine("Resultado da subtração: ");
            subtracao.Matematica();
            Console.WriteLine("Resultado da soma: ");
            soma.Matematica();
            Console.WriteLine("Resultado da divisao: ");
            divisao.Matematica();
            Console.WriteLine("Resultado da multiplicação: ");
            multiplicacao.Matematica();
        }
        
    }
}
