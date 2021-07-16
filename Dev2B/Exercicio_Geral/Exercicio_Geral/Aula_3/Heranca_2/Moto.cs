using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_3.Heranca_2
{
    public class Moto : Atributos
    {
        public Moto(string cor, int velocidademaxima, string combustivel, string marca, int quantidaderodas, int quantidadepassageiros) : base(cor, velocidademaxima, combustivel, marca, quantidaderodas, quantidadepassageiros)
        {

        }
        public bool PossuiCarenagem { get; set; }


    }
}
