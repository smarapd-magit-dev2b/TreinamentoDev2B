using System;
using System.Collections.Generic;
using System.Text;
using Aula3.Classes;

namespace Aula3.Exercicio1
{
    public class Fornecedor : Pessoa1
    {
        public string Cnpj { get; set; }
        public string Segmento { get; set; }
        public string Produto { get; set; }

        public Fornecedor(string nome, string endereco, string telefone, string cnpj, string segmento, string produto)
           : base(nome, endereco, telefone)
        {
            Cnpj = cnpj;
            Segmento = segmento;
            Produto = produto;
        }

    }
}
