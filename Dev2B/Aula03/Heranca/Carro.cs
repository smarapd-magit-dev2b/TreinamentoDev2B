using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Heranca
{
    public class Carro: Veiculo
    {
        public int QuantidadePortas { get; set; }
        public int QuantidadeMaximaPassageiros { get; set; }
        public Boolean PossuiStep { get; set; }
        public Boolean PossuiTracaoTraseira { get; set; }
    }
}
