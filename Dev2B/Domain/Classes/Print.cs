using System;

namespace Domain.Classes
{
    public class Print
    {
        private object Objeto { get; set; }

        public Print(object objeto)
        {
            Objeto = objeto;
        }

        public void PrintarPropriedades()
        {
            Console.WriteLine($"{Objeto.GetType().Name}\n");
            foreach (var propriedade in Objeto.GetType().GetProperties())
                Console.WriteLine($"{propriedade.Name}: {propriedade.GetValue(Objeto)}");
        }
    }
}
