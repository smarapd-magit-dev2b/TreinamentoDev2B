using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto
{    
    //Dto para atualizar apenas o Nome, Sobrenome e Cpf da pessoa.
    public class PessoaPutBasicDto
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cpf { get; set; }
    }
}
