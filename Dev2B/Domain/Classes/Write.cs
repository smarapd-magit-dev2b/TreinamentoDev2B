using System;

namespace Domain.Classes
{
    public class Write
    {
        private object Objeto { get; set; }

        public Write(object objeto)
        {
            Objeto = objeto;
        }

        public void WritePropriedades()
        {
            Console.WriteLine($"\n{Objeto.GetType().Name}\n");
            foreach (var propriedade in Objeto.GetType().GetProperties())
                Console.WriteLine($"{propriedade.Name}: {propriedade.GetValue(Objeto)}");
        }
    }
}
