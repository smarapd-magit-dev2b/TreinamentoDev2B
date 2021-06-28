using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Classes
{
    class Fornecedor : Pessoa
    {


        public string Cnpj { get; set; }
        public string Segmento { get; set; }
        public string Produto { get; set; }

       

        public Fornecedor(string nome, string endereco, string telefone, string celular, string cnpj, string segmento, string produto) 
            : base(nome, telefone, celular, endereco)
        {
            Cnpj = cnpj;
            Segmento = segmento;
            Produto = produto;
        }
    }
}
