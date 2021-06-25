using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public abstract class Banco
    {
        public int NumConta { get; set; }
        public decimal MovSaque { get; set; }
        public decimal MovDeposito { get; set; }
        public int Agencia { get; set; }

        public abstract void ImpreExtrato();
        public abstract decimal Movimentar();
        public abstract decimal Sacar();
        public abstract void AplicarRendimento();

        

        
    }
}
