﻿using System;

namespace Dev2bDomain.Entities
{
    public class PessoaEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Altura { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Peso { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }
        public bool UsuarioAtivo { get; set; }
    }
}
