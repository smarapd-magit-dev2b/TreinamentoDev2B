using Aula7.ExemploRuim;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7
{
    public class Execucao
    {
        public void Execute()
        {
            ExemploBom.Gato gato = new ExemploBom.Gato();
            ExemploRuim.Cachorro cachorro = new ExemploRuim.Cachorro();
            ExRuim(cachorro);
            ExBom(gato);
        }
        private void ExRuim(Animal animal)
        {
            ExemploRuim.Cachorro cachorro = new ExemploRuim.Cachorro();
            ExemploRuim.Gato gato = new ExemploRuim.Gato();
            if (animal.Tipo == "cachorro")
            {
                Console.WriteLine(cachorro.EmitirSom());
            }
            else if (animal.Tipo == "gato")
            {
                Console.WriteLine(gato.EmitirSom());
            }
        }
        private void ExBom(ExemploBom.Animal animal)
        {
            Console.WriteLine(animal.EmitirSom());  
        }
    }
}
