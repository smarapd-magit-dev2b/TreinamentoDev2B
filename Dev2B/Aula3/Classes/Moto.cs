using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Classes
{
    public class Moto : Veiculo
    {
        public bool PossuiCarenagem { get; set; }
        public Moto(int vmax, string tipoCombustivel, string marca)
           : base(vmax, tipoCombustivel, marca)
        {

        }
    }
}
