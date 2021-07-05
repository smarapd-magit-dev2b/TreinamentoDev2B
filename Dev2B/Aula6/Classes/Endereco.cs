using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6.Classes
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }

        public override string ToString()
        {
            return $"Logradouro: {Logradouro} | Numero: {Numero} | Complemento: {Complemento} | Bairro: {Bairro}";
        }
    }
}
