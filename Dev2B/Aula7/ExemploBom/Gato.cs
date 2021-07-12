using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7.ExemploBom
{
    public class Gato : Animal
    {
        public Gato()
        {
            Tipo = "gato";
        }

        public override string EmitirSom()
        {
            return "Miau";
        }
    }
}
