using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7.ExemploBom
{
    public class Cachorro : Animal
    {
        public override string EmitirSom()
        {
            return "Au au";
        }
        public Cachorro()
        {
            Tipo = "cachorro";
        }
    }
}
