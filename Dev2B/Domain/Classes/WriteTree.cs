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

        public static void PropriedadesNumArquivo(object objeto,
                                        params string[] titulos)
        {
            string arvore = "";
            SubPropriedadesNumArquivo(objeto, "   ", titulos.ToList(), 0, ref arvore);
            arvore += "\n";

            string nomeArquivo;
            if (titulos.ToList().Count > 0)
                nomeArquivo = titulos[0];
            else
                nomeArquivo = $"\n{objeto.GetType().Name}\n\n";


            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{nomeArquivo}.txt"), arvore);

            Console.WriteLine($"Arquivo criado em {AppDomain.CurrentDomain.BaseDirectory}\nCom o nome de '{nomeArquivo}.txt'");
        }

        private static void SubPropriedadesNumArquivo(object objeto,
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
                        SubPropriedadesNumArquivo(item, $"{tabulacao}   ", titulos, titulo + 1, ref arvore);
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
                                SubPropriedadesNumArquivo(item, $"{tabulacao}   ", titulos, titulo + 1, ref arvore);
                            break;

                        default:
                            SubPropriedadesNumArquivo(propriedade.GetValue(objeto), $"{tabulacao}   ", titulos, titulo + 1, ref arvore);
                            break;
                    }
                }
            }
        }
    }
}
