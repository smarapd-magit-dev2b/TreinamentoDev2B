﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula08._SOLID.ClassesAula08.ExemploBomAlternativo
{
    public class Comida : ILojaAlimentos
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public decimal ValorUnit { get; set; }
        public DateTime Validade { get; set; }
        public int QtdEstoque { get; set; }

        public void EstoqueAlimentos()
        {
            ID = 3;
            Marca = "Friboi";
            ValorUnit = 40.99m;
            QtdEstoque = 30;
            Validade = new DateTime(08 / 10 / 2020).Date;
        }
    }
}
