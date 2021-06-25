using System;
using System.Collections.Generic;
using System.Text;
using Aula3.Interfaces;

namespace Aula3.Domain
{
    public class PessoaFisica : Pessoa, IImposto
    {
        public PessoaFisica(string nome, string telefone, string endereco)
            : base (nome, telefone, endereco)
        {

        }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public decimal CalcularImposto(decimal valor)
        {
            var valorFinal = valor * (valor / 1.5m);
            return valorFinal;
        }

        public override void EscreverInformacoes()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(Telefone);
            Console.WriteLine(Endereco);
            Console.WriteLine(CPF);
            Console.WriteLine(DataNascimento);
        }
    }
}
