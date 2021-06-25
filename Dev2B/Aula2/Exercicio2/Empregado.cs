using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio2
{
    class Empregado
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public decimal SalarioMensal { get; set; }

        public Empregado(string nome, string sobrenome, decimal salario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            SalarioMensal = salario;
        }
        public void reajustarSalario(decimal reajuste)
        {
            SalarioMensal = SalarioMensal * reajuste;
        }
        public decimal calcularSalarioAtual()
        {
            decimal SalarioAnual = SalarioMensal * 12;
            return SalarioAnual;
        }
    }
}
