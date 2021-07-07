using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Classes.ClassesAbstr
{
    public class Cachorro : Animal
    {
        public Cachorro(string tipo) : base(tipo)
        {

        }

        public override string EmitirSom()
        {
            return "au au";
        }
    }
}
