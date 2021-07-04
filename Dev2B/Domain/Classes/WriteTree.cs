using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Classes
{
    public static class WriteTree
    {
        public static void Propriedades(object objeto,
                                        params string[] titulos) => SubPropriedades(objeto, "   ", titulos.ToList(), 0);

        private static void SubPropriedades(object objeto,
                                            string tabulacao,
                                            List<string> titulos,
                                            int titulo)
        {
            var classe = objeto.GetType();

            if (titulos.Count > titulo)
                Console.WriteLine($"\n{tabulacao}{titulos[titulo]}\n");
            else
                Console.WriteLine($"\n{tabulacao}{classe.Name}\n");

            foreach (var propriedade in classe.GetProperties())
            {
                switch (propriedade.PropertyType.Namespace)
                {
                    case "System":
                        Console.WriteLine($"{tabulacao}{propriedade.Name}: {propriedade.GetValue(objeto)}");
                        break;

                    case "System.Collections.Generic":
                        if (!(propriedade.GetValue(objeto) is IEnumerable lista))
                            break;

                        Console.WriteLine($"\n{tabulacao}{propriedade.Name}\n");
                        foreach (var item in lista)
                            SubPropriedades(item, $"{tabulacao}   ", titulos, titulo + 1);
                        break;

                    default:
                        SubPropriedades(propriedade.GetValue(objeto), $"{tabulacao}   ", titulos, titulo + 1);
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
