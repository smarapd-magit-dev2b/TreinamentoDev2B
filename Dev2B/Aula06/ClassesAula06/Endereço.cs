using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06_Lambdas.ClassesAula06
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }

        public override string ToString()
        {
            return($"Logradouro: {Logradouro}" +
                              $"Bairro: {Bairro}" +
                              $"Numero: {Numero}" +
                              $"Complemento: {Complemento}"
                              );

        }
    }
}
