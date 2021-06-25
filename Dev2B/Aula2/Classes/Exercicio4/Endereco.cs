using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Endereco
    {
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Rua { get; set; }

        public Endereco()
        {

        }
        public Endereco(string cidade, string estado, string rua)
        {
            Cidade = cidade;
            Estado = estado;
            Rua = rua;
        }
    }
}
