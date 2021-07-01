using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Heranca
{
    public class Funcionario: Pessoa
    {
        public string CPF { get; set; }
        public string RG { get; set; }
        public string CNH { get; set; }
        public int QuantidadeFilhos { get; set; }
        public string EstadoCivil { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}
