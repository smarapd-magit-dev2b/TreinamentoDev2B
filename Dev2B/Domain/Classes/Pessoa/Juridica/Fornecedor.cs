﻿using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Pessoa.Juridica
{
    public class Fornecedor : PessoaJuridica
    {
        public string Segmento { get; set; }
        public string Produto { get; set; }
    }
}
