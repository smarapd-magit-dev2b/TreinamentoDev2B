using System;
using System.Collections.Generic;
using System.Text;

namespace Aula08._SOLID.ClassesAula08.ExemploBom
{
    public class Roupas : ILoja
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public decimal ValorUnit { get; set; }
        public int QtdEstoque { get; set; }
        public string Material { get; set; }

        public void Estoque()
        {
            ID = 1;
            Marca = "Polo";
            ValorUnit = 100.00m;
            QtdEstoque = 50;
            Material = "Algodão";

        }
    }
}
