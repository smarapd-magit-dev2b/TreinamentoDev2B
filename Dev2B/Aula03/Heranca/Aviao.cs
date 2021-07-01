using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Heranca
{
    public class Aviao: Veiculo
    {
        public int QuantidadePilotos { get; set; }
        public int QuantidadeAcentos { get; set; }
        public string Porte { get; set; }
        public int QuantidadeMaximaPassageiros { get; set; }
    }
}
