using System;
using System.Collections.Generic;
using System.Text;

namespace Herança1
{
    public class Funcionario : Filho
    {
        //Construtor-------------------------
        public Funcionario(string nome, string endereço, string telefone) : base(nome, endereço, telefone)
        {

        }

        public string Salario { get; set; }

        public string Cnh { get; set; }

        public DateTime Data { get; set; }








    }
}
