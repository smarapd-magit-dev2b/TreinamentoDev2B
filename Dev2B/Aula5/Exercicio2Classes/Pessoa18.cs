using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Classes
{
    public class Pessoa18
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DatNascimento { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} {Sobrenome}. Telefone: {Telefone}. Nasc: {DatNascimento.ToString("dd/MM/yyyy")}";
        }
    }
}
