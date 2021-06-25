using System;
using System.Collections.Generic;
using System.Text;
using Aula3.Interfaces;

namespace Aula3.Domain
{
    public class PessoaJuridica : Pessoa, IImposto
    {
        public PessoaJuridica(string nome, string telefone, string endereco)
            : base(nome, telefone, endereco)
        {

        }
        public string Cnpj { get; set; }
        public string InscricaoMunicipal { get; set; }

        public override void EscreverInformacoes()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(Telefone);
            Console.WriteLine(Endereco);
            Console.WriteLine(Cnpj);
            Console.WriteLine(InscricaoMunicipal);
        }

        public decimal CalcularImposto(decimal valor)
        {
            var valorFinal = valor * (valor / 3.5m);
            return valorFinal;
        }
    }
}
