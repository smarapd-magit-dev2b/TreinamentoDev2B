using System;
using System.Collections.Generic;
using System.Text;

namespace Aluno
{
    public class DadosAluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Id { get; set; }
        public string RA { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }


        public override string ToString()
        {
            return $"Nome: {Nome}. Idade: {Idade}. Nasc.: {DataNascimento.ToString("dd/MM/yyyy")} RA: {RA}. Nome do Pai: {NomePai}. Nome da Mãe: {NomeMae}.\n";
        }
    }
}
