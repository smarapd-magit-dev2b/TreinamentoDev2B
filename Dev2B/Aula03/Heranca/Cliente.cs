using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Heranca
{
    public class Cliente: Pessoa
    {
        public string CPF { get; set; }
        public string RG { get; set; }
        public int QuantidadeFilhos { get; set; }
        public string EstadoCivil { get; set; }
    }
}
