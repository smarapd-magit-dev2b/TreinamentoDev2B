using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1
{
    class Cliente : Pessoa
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public int QtdFilhos { get; set; }
        public string EstadoCivil { get; set; }

    }
}
