using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
