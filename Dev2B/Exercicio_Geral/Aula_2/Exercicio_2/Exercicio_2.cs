using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_2.Exercicio_2
{
    public class Exercicio_2
    {
        public void Executar_Aula2Ex2()
        {
            //Variaveis---------------------

            Empregado Trab;

            Console.WriteLine("Digite as informações: ");

            //Nome--------------------------

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            //Sobrenome---------------------

            Console.WriteLine("Digite o sobrenome: ");
            string sobrenome = Console.ReadLine();

            //Salario-----------------------

            Console.WriteLine("Digite seu salário: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            Trab = new Empregado(nome, sobrenome, salario);

            //Mensagem----------------------

            Console.WriteLine("\n O salario anual é R$ " + Trab.calcularSalarioAtual());

            Console.WriteLine("\n O reajuste do salario é R$ " + Trab.reajustarSalario());





        }

    }
}
