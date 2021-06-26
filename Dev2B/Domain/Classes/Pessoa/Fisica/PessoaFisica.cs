using Domain.Interfaces;
using System;

namespace Domain.Classes.Pessoa.Fisica
{
    public class PessoaFisica : Pessoa, IImprimirDadosEssenciais
    {
        public string Sobrenome { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public Data DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Cnh { get; set; }
        public int QuantidadeFilhos { get; set; }
        public string EstadoCivil { get; set; }
        public void ImprimirDadosEssenciais()
        {
            Console.WriteLine($"Cliente\n\nNome: {Nome}\nCPF: {Cpf}\nRG: {Rg}\n");
            Endereco.Imprimir();
        }
    }
}
