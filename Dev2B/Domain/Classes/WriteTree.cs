using System;
using System.Collections;

namespace Domain.Classes
{
    public static class WriteTree
    {
        public static void Propriedades(object objeto)
        {
            string[] a = null;
            ForEachTree(objeto, ref a, "   ");
        }
        public static void Propriedades(object objeto, params string[] titulos)
        {
            ForEachTree(objeto, ref titulos, "   ");
        }

        private static void ForEachTree(object objeto, ref string[] titulos, string espacamento)
        {
            var classe = objeto.GetType();

            if (titulos.Length == 0)
                Console.WriteLine($"\n{Espacamento}{classe.Name}\n");
            else
            {
                Console.WriteLine($"\n{Espacamento}{Titulo}\n");
                Titulo = null;
            }

            foreach (var propriedade in classe.GetProperties())
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
                            ForEachTree(item);
                        Espacamento = Espacamento.Substring(3);
                    }
                }
                else
                {
                    Espacamento += "   ";
                    ForEachTree(propriedade.GetValue(objeto));
                    Espacamento = Espacamento.Substring(3);
                }
            }
            Console.WriteLine();
        }
    }
}
