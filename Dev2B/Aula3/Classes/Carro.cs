using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Classes
{
    public class Carro : Veiculo
    {
        public int QtdPortas { get; set; }
        public bool PossuiStep { get; set; }
        public bool PossuiTracao { get; set; }

        public Carro(int vmax, string tipoCombustivel, string marca)
            : base(vmax, tipoCombustivel, marca)
        {

        }
    }
}
