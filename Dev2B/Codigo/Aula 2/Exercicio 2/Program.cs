using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
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
