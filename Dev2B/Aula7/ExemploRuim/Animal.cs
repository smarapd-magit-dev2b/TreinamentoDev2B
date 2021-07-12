using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7.ExemploRuim
{
    public abstract class Animal
    {
        public string Tipo { get; set; }

        public abstract string EmitirSom();
    }
}
