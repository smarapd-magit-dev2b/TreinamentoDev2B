using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2
{
    public class Empregado
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public decimal SalarioMensal { get; set; }

        public Empregado()
        {

        }

        public Empregado(string nome, string sobreNome, decimal salarioMensal)
        {
            Nome = nome;
            SobreNome = sobreNome;
            if (salarioMensal < 0)
                salarioMensal = 0.0m;
            else
                SalarioMensal = salarioMensal;
        }

        public decimal CalcularSalarioAnual()
        {
            return SalarioMensal * 12;
        }

        public decimal ReajustarSalario(decimal porcentagem)
        {
            return SalarioMensal + (SalarioMensal * porcentagem/100);
        }

        public void EscreverEmpregado()
        {
            Console.Write("Porcentagem de aumento salarial: ");
            decimal porcentagem = Convert.ToDecimal(Console.ReadLine());
            decimal salarioAtualAnual = CalcularSalarioAnual();
            decimal salarioReajustado = ReajustarSalario(porcentagem);
            Console.WriteLine($"\n\nNome do empregado: {Nome} {SobreNome}");
            Console.WriteLine($"Salário mensal: {SalarioMensal}");
            Console.WriteLine($"Salário anual: {salarioAtualAnual}");
            Console.WriteLine($"Salário reajustado: {salarioReajustado}");
        }
    }
}
