using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Classes
{
    public class Aviao : Veiculo
    {
        public int QtdPilotos { get; set; }
        public int QtdAcentos { get; set; }
        public string Porte { get; set; }

        public Aviao(int vmax, string tipoCombustivel, string marca) 
            : base(vmax, tipoCombustivel, marca)
        {

        }
    }
}
