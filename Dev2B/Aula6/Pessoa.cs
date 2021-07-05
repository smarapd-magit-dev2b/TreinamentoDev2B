﻿using System;
using System.Collections.Generic;

namespace Aula6
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Raca { get; set; }
        public Endereco Endereco { get; set; }
        public List<Pessoa> Filhos { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}\n Data de Nascimento {DataNascimento} \n Raça: {Raca}\n";
        }
    }
}
