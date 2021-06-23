using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
    class Pessoa
    {
        public int idade { get; set; }
        public decimal peso { get; set; }
        public decimal altura { get; set; }

        public Pessoa()
        {

        }
        public Pessoa(int idade, decimal peso, decimal altura)
        {
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }

    }
}
