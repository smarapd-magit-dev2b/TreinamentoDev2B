using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Fornecedor : PessoaJuridica
    {
        public string Segmento { get; set; }
        public string Produto { get; set; }
    }
}
