using System.Collections.Generic;

namespace Domain.Classes
{
    public class Cadastros
    {
        public List<object> ListaObjetos { get; set; }

        public void AddItem(object item)
        {
            ListaObjetos.Add(item);
        }
    }
}
