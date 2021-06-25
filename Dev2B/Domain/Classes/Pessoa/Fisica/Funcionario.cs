using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Funcionario : PessoaFisica
    {
        public decimal Salario { get; set; }
        public Data DataAdmissao { get; set; }
    }
}
