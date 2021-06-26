using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3
{
    class Aviao : Veiculo
    {
        public int QuantidadePilotos { get; set; }
        public int QuantidadeAcentos { get; set; }
        public string Porte { get; set; }
    }
}
