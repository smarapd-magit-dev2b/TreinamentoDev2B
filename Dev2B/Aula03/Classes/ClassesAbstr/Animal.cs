using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Classes.ClassesAbstr
{
    public abstract class Animal
    {
        public string Tipo { get; set; }        

        public Animal (string tipo)
        {
            Tipo = tipo;         
        }

        public abstract string EmitirSom();

    }
}
