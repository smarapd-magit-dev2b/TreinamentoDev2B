using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Heranca
{
    public class Fornecedor: Pessoa
    {
        public string CNPJ { get; set; }
        public string Segmento { get; set; }
        public string Produto { get; set; }
    }
}
