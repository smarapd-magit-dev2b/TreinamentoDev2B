using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Empregado
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public decimal SalarioMensal { get; set; }

        public Empregado(string nome, string sobreNome, decimal salarioMensal)
        {
            Nome = nome;
            SobreNome = sobreNome;
            SalarioMensal = salarioMensal < 0 ? 0 : salarioMensal;
        }

        public decimal CalcularSalarioAnual()
        {
            return SalarioMensal * 12;
        }

        public void ReajustarSalario(decimal aumento)
        {
            decimal ValorDeAcrecimo = (SalarioMensal / 100) * aumento;
            SalarioMensal += ValorDeAcrecimo; 
        }
    }
}
