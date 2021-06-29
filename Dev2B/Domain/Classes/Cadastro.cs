using System;
using System.Collections.Generic;

namespace Domain.Classes
{
    public class Cadastro<T>
    {
        public string Tittle { get; set; }
        private object Objeto { get; set; }
        public List<T> ListaObjetos { get; set; }

        public Cadastro(T objeto)
        {
            Objeto = objeto;
        }

        public Cadastro(T objeto, string tittle)
        {
            Tittle = tittle;
            Objeto = objeto;
        }

        public void Cadastrar()
        {
            if (Tittle != null)
                Console.WriteLine(Tittle);
            else
                Console.WriteLine(Objeto.GetType().Name);

            Console.WriteLine();

            foreach (var propriedade in Objeto.GetType().GetProperties())
            {
                if (propriedade.PropertyType.Name != "DateTime")
                {
                    Console.Write($"Digite o valor da propriedade {propriedade.Name}: ");
                    if (propriedade.PropertyType.Name == "Int32")
                        propriedade.SetValue(Objeto, int.Parse(Console.ReadLine()));
                    else if (propriedade.PropertyType.Name == "Decimal")
                        propriedade.SetValue(Objeto, decimal.Parse(Console.ReadLine()));
                    else if (propriedade.PropertyType.Name == "String")
                        propriedade.SetValue(Objeto, Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"{propriedade.Name}\n");
                    Console.Write($"Digite o Dia: ");
                    var dia = int.Parse(Console.ReadLine());
                    Console.Write($"Digite o Mês: ");
                    var mes = int.Parse(Console.ReadLine());
                    Console.Write($"Digite o Ano: ");
                    var ano = int.Parse(Console.ReadLine());
                    propriedade.SetValue(Objeto, new DateTime(ano, mes, dia));
                }
            }
        }

    }
}
