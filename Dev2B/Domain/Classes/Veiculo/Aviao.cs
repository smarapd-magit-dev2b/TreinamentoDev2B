using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Veiculo
{
    class Aviao : Veiculo
    {
        public int QuantidadePilotos { get; set; }
        public int QuantidadeAcentos { get; set; }
        public string Porte { get; set; }
    }
}
