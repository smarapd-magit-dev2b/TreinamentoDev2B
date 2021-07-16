using System;
using System.Collections.Generic;
using System.Text;

namespace Herança1
{
    public  class Filho : Mãe
    {
        public Filho (string nome, string endereço, string telefone) : base(nome, endereço, telefone)
        {

        }
            
        public string Cpf { get; set; }

        public string Rg { get; set; }

        public string QuantidadeFilhos { get; set; }

        public string EstadoCivil { get; set; }


    }
}
