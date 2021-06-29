using System;
using System.Collections.Generic;
using System.Text;

namespace Herança_2
{
    public class Carro : Atributos
    {
        public Carro(string cor, int velocidademaxima, string combustivel, string marca, int quantidaderodas, int quantidadepassageiros) : base(cor, velocidademaxima, combustivel, marca, quantidaderodas, quantidadepassageiros)
        {

        }
        public int QuantidadePortas { get; set; }
      
      public bool PossuiStep { get; set; }
     
      public bool PossuiTraçãoTraseira { get; set; }
    
    
    }
}
