using System;
using System.Collections.Generic;
using System.Text;

namespace Aula08._SOLID.ClassesAula08.ExemploBomAlternativo
{
    public class Roupas : ILojaRoupas
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public decimal ValorUnit { get; set; }
        public int QtdEstoque { get; set; }
        public string Material { get; set; }

        public void EstoqueRoupas()
        {
            ID = 1;
            Marca = "Polo";
            ValorUnit = 100.00m;
            QtdEstoque = 50;
            Material = "Algodão";
        }
    }
}
