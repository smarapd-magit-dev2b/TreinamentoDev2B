using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7.ExemploRuim
{
    class Cachorro : Animal
    {
        public Cachorro()
        {
            Tipo = "cachorro";
        }

        public override string EmitirSom()
        {
            return "Au au";
        }
    }
}
