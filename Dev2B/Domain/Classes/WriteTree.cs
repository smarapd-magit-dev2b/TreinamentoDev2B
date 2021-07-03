using System;
using System.Collections;
using System.Linq;

namespace Domain.Classes
{
    public static class WriteTree
    {
        public static void Propriedades(object objeto, params string[] titulos)
        {
            var classe = objeto.GetType();
            var titulosList = titulos.ToList();

            if (!titulosList.Any())
                Console.WriteLine($"\n{classe.Name}\n");
            else
            {
                Console.WriteLine($"\n{titulosList.First()}\n");
                _ = titulosList.Remove(titulosList.First());
            }

            foreach (var propriedade in classe.GetProperties())
            {
                if (propriedade.PropertyType.Namespace == "System")
                    Console.WriteLine($"{propriedade.Name}: {propriedade.GetValue(objeto)}");
                else if (propriedade.PropertyType.Namespace == "System.Collections.Generic")
                {
                    var lista = (IEnumerable)propriedade.GetValue(objeto);
                    if (lista != null)
                    {
                        Console.WriteLine($"\n{propriedade.Name}\n");
                        foreach (var item in lista)
                            Propriedades(item);
                    }
                }
                else
                    Propriedades(propriedade.GetValue(objeto));
            }
            Console.WriteLine();
        }
    }
}
