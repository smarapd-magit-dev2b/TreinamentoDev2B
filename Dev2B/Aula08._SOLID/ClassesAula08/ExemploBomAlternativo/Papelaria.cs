using System;
using System.Collections.Generic;
using System.Text;

namespace Aula08._SOLID.ClassesAula08.ExemploBomAlternativo
{
    public class Papelaria : ILojaPapelaria
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public decimal ValorUnit { get; set; }
        public int QtdEstoque { get; set; }
        public string Tipo { get; set; }

        public void EstoquePapelaria()
        {
            ID = 2;
            Marca = "Faber Castel";
            ValorUnit = 20.00m;
            QtdEstoque = 300;
            Tipo = "Lápis de cor";
        }
    }
}
