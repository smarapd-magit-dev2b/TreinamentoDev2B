using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Domain.Classes
{
    public static class WriteTree
    {
        public static void Propriedades(object objeto,
                                        params string[] titulos)
        {
            string arvore = "";
            SubPropriedades(objeto, "   ", titulos.ToList(), 0, ref arvore);
            Console.WriteLine(arvore);
        }

        public static void PropriedadesNumArquivo(object objeto,
                                        params string[] titulos)
        {
            string arvore = "";
            SubPropriedades(objeto, "   ", titulos.ToList(), 0, ref arvore);
            arvore += "\n";

            string nomeArquivo;
            if (titulos.ToList().Count > 0)
                nomeArquivo = titulos[0];
            else
                nomeArquivo = $"\n{objeto.GetType().Name}\n\n";


            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{nomeArquivo}.txt"), arvore);

            Console.WriteLine($"Arquivo criado em {AppDomain.CurrentDomain.BaseDirectory}\nCom o nome de '{nomeArquivo}.txt'");
        }

        private static void SubPropriedades(object objeto,
                                            string tabulacao,
                                            List<string> titulos,
                                            int titulo,
                                            ref string arvore)
        {
            var classe = objeto.GetType();

            if (titulos.Count > titulo)
                arvore += $"\n{tabulacao}{titulos[titulo]}\n\n";
            else
                arvore += $"\n{tabulacao}{classe.Name}\n\n";

            if (classe.Namespace == "System.Collections.Generic")
            {
                if (objeto is IEnumerable lista)
                    foreach (var item in lista)
                        SubPropriedades(item, $"{tabulacao}   ", titulos, titulo + 1, ref arvore);
            }
            else
            {
                foreach (var propriedade in classe.GetProperties())
                {
                    switch (propriedade.PropertyType.Namespace)
                    {
                        case "System":
                            arvore += $"{tabulacao}{propriedade.Name}: {propriedade.GetValue(objeto)}\n";
                            break;

                        case "System.Collections.Generic":
                            if (!(propriedade.GetValue(objeto) is IEnumerable lista))
                                break;

                            arvore += $"\n{tabulacao}{propriedade.Name}\n\n";
                            foreach (var item in lista)
                                SubPropriedades(item, $"{tabulacao}   ", titulos, titulo + 1, ref arvore);
                            break;

                        default:
                            SubPropriedades(propriedade.GetValue(objeto), $"{tabulacao}   ", titulos, titulo + 1, ref arvore);
                            break;
                    }
                }
            }
        }
    }
}
