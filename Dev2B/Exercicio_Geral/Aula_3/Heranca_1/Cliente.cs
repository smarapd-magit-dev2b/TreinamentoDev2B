﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_3.Exercicio_1
{
    public class Cliente : Filho
    {
        //Construtor-------------------------
        public Cliente(string nome, string endereço, string telefone) : base(nome, endereço, telefone)
        {

        }
        public string Profissao { get; set; }

    }
}
