using Domain.Interfaces;
using System;

namespace Domain.Classes.Pessoa.Juridica
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
