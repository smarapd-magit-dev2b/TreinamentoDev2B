using System;
using System.Collections.Generic;
using System.Text;

namespace Herança1
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
