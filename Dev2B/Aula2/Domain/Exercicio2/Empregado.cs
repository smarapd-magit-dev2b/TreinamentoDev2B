using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Empregado
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public decimal SalarioMensal { get; set; }

        public Empregado(string nome, string sobrenome, decimal salariomensal)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            SalarioMensal = salariomensal;

            if (SalarioMensal < 0)
                SalarioMensal = 0.0m;
            else
                SalarioMensal = salariomensal;
        }

        private decimal calcularSalarioAtual()
        {
            return SalarioMensal * 12;
        }

        private decimal reajustarSalario()
        {
            Console.WriteLine("Porcentagem de aumento: ");
            decimal porcentagem = decimal.Parse(Console.ReadLine());
            SalarioMensal = ((porcentagem / 100) * SalarioMensal) + SalarioMensal;
            return SalarioMensal;
        }
        private void GetNomeCompleto()
        {
            Console.WriteLine($"{Nome} {Sobrenome}");
        }

        public void EscreverInformacoes()
        {
            GetNomeCompleto();
            reajustarSalario();
            Console.WriteLine($"Salário Mensal: {SalarioMensal}");
            Console.WriteLine($"Salário Anual: {calcularSalarioAtual()}");
        }
    }
}
