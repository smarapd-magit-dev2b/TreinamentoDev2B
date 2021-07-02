using System;
using System.Collections;

namespace Domain.Classes
{
    public class Write
    {
        private object Objeto { get; set; }
        private string Titulo { get; set; }
        private string Titulo1 { get; set; }
        private string Espacamento { get; set; }

        public Write(object objeto)
        {
            Objeto = objeto;
        }

        public Write(object objeto, string titulo)
        {
            Objeto = objeto;
            Titulo = titulo;
        }
        public Write(object objeto, string titulo, string titulo1)
        {
            Objeto = objeto;
            Titulo = titulo;
            Titulo1 = titulo1;
        }

        public void Propriedades()
        {
            Espacamento = "   ";
            ForEach(Objeto);
        }

        private void ForEach(object objeto)
        {
            if (Titulo != null)
            {
                Console.WriteLine($"\n{Espacamento}{Titulo}\n");
                Titulo = null;
            }
            else if (Titulo1 != null)
            {
                Console.WriteLine($"\n{Espacamento}{Titulo1}\n");
                Titulo = null;
            }
            else
                Console.WriteLine($"\n{Espacamento}{objeto.GetType().Name}\n");

            foreach (var propriedade in objeto.GetType().GetProperties())
            {
                if (propriedade.PropertyType.Namespace == "System")
                    Console.WriteLine($"{Espacamento}{propriedade.Name}: {propriedade.GetValue(objeto)}");
                else if(propriedade.PropertyType.Namespace == "System.Collections.Generic")
                {
                    var lista = (IEnumerable) propriedade.GetValue(objeto);
                    if (lista != null)
                    {
                        Espacamento += "   ";
                        Console.WriteLine($"\n{Espacamento}{propriedade.Name}\n");
                        Espacamento += "   ";
                        foreach (var item in lista)
                            ForEach(item);
                        Espacamento = Espacamento.Substring(3);
                    }
                }
                else
                {
                    Espacamento += "   ";
                    ForEach(propriedade.GetValue(objeto));
                    Espacamento = Espacamento.Substring(3);
                }
            }
            Console.WriteLine();
        }
    }
}
