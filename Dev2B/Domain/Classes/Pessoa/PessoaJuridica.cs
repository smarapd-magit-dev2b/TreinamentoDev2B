using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class PessoaJuridica : Pessoa, IImprimirDadosEssenciais
    {
        public string Cnpj { get; set; }
        public void ImprimirDadosEssenciais()
        {
            Console.WriteLine($"Fornecedor\n\nNome: {Nome}\nCNPJ: {Cnpj}\n");
            Endereco.Imprimir();
        }
    }
}
