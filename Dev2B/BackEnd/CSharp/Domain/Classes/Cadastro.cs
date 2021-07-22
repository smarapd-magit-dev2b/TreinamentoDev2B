using System;

namespace Common.Classes
{
    public class Cadastro
    {
        private string _tittle;
        public string Tittle
        {
            get => _tittle;
            set => _tittle = value != null ? $"\n{value}\n" : null;
        }
        private object Objeto { get; set; }

        public Cadastro(object objeto)
        {
            Tittle = null;
            Objeto = objeto;
        }

        public Cadastro(object objeto, string tittle)
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
                else if (propriedade.PropertyType.Name == "DateTime")
                {
                    Console.Write(
                        $"\n{propriedade.Name}\n\n" +
                        "Digite o Dia: "
                        );
                    var dia = int.Parse(Console.ReadLine());

                    Console.Write("Digite o Mês: ");
                    var mes = int.Parse(Console.ReadLine());

                    Console.Write("Digite o Ano: ");
                    var ano = int.Parse(Console.ReadLine());

                    propriedade.SetValue(Objeto, new DateTime(ano, mes, dia));
                }
            }
        }

    }
}
