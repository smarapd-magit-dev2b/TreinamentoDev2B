using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }
        public bool PossuiStep { get; set; }
        public bool PossuiTracaoTraseira { get; set; }
    }
}
