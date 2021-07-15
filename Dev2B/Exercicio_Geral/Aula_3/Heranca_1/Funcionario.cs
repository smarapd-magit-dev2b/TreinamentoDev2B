using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_3.Exercicio_1
{
    public class Funcionario : Filho
    {
        public Funcionario(string nome, string endereço, string telefone) : base(nome, endereço, telefone)
        {

        }

        public string Salario { get; set; }

        public string Cnh { get; set; }

        public DateTime Data { get; set; }

    }
}
