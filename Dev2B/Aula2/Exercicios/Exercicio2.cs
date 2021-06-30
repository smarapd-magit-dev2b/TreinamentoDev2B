using Domain.Classes.Pessoa.Fisica;
using Domain.Interfaces;
using System;

namespace Aula2
{
    class Exercicio2 : IExecute
    {
        public void Cadastrar()
        {
            Console.Write("Exercício 2\n\n" +
                "Empregado\n\n" +
                "Digite seu Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Digite seu Sobrenome: ");
            var sobrenome = Console.ReadLine();

            Console.Write("Digite seu Salário: ");
            var salario = decimal.Parse(Console.ReadLine());

            Empregado empregado = new Empregado(nome, sobrenome, salario);

            Console.WriteLine($"O salário anual de {empregado.Nome + empregado.Sobrenome} é R${empregado.CalcularSalarioAtual()}");

            empregado.ReajustarSalario(0.15m);

            Console.WriteLine($"Com um aumento de 15%, seu salário mensal será {empregado.Salario}");
        }
    }
}
