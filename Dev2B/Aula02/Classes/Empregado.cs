using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02.Classes
{
    public class Empregado
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public decimal SalarioMensal { get; set; }

        public Empregado(string nome, string sobrenome, decimal salarioMensal)
        {

            Nome = nome;
            Sobrenome = sobrenome;
            SalarioMensal = salarioMensal;

            if (salarioMensal < 0)
                SalarioMensal = 0.0m;
            else
                SalarioMensal = salarioMensal;
        }

        public decimal CalcularSalarioAtual()
        {
            return SalarioMensal * 12;
        }

        public decimal ReajustarSalario(int porcentagem)
        {
            return SalarioMensal + (SalarioMensal * porcentagem) / 100;
        }
    }
}
