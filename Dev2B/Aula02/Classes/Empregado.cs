using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Classes
{
    public class Empregado
    {
        private string Nome { get; set; }
        private string Sobrenome { get; set; }
        private decimal Salario { get; set; }

        public Empregado (string nome, string sobrenome, decimal salario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            if (salario < 0)
                Salario = 0.0m;
            else
                Salario = salario;            
        }

        private decimal CalcularSalarioAtual()
        {
            return Salario * 12;
        }

        private decimal ReajustarSalario(decimal porcentagem)
        {
            return Salario + Salario * porcentagem/100;
        }

        public void EscreverEmpregado()
        {
            Console.WriteLine("\nEntre com a porcentagem de aumento\n");
            decimal porcentagem = Convert.ToDecimal(Console.ReadLine());
            decimal salarioAtualAnual = CalcularSalarioAtual();
            decimal salarioReajustado = ReajustarSalario(porcentagem);
            Console.WriteLine($"\nO nome é {Nome}.");
            Console.WriteLine($"O sobrenome é {Sobrenome}.");
            Console.WriteLine($"O salario é {Salario}.");
            Console.WriteLine($"O salario anual é {salarioAtualAnual}.");
            Console.WriteLine($"O valor do salario reajustado é {salarioReajustado}.");
        }




    }
}
