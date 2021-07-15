using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_3.Heranca_2
{
    public class Avião : Atributos
    {
        public Avião(string cor, int velocidademaxima, string combustivel, string marca, int quantidaderodas, int quantidadepassageiros) : base(cor, velocidademaxima, combustivel, marca, quantidaderodas, quantidadepassageiros)
        {

        }

        public int QuantidadePilotos { set; get; }

        public int QuantidadeAcentos { set; get; }

        public decimal Porte { set; get; }

    }
}
