using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_3.Exercicio_1
{
    public class Fornecedor : Mãe
    {
        public Fornecedor(string nome, string telefone, string endereço) : base(nome, telefone, endereço)
        {

        }

        public string Cnpj { get; set; }

        public string Produto { get; set; }

        public string Segmento { get; set; }

    }
}
