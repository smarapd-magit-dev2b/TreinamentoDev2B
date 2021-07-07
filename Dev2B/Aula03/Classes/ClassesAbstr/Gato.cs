using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Classes.ClassesAbstr
{
    class Gato: Animal
    {
        public Gato(string tipo) : base(tipo)
        {

        }

        public override string EmitirSom()
        {
            return "miau";
        }
    }

}
