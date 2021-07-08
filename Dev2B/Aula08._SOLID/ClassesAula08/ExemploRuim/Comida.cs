using System;
using System.Collections.Generic;
using System.Text;

namespace Aula08._SOLID.ClassesAula08.ExemploRuim
{
    public class Comida : ILoja
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public decimal ValorUnit { get; set; }
        public DateTime Validade { get; set; }
        public int QtdEstoque { get; set; }

        public void Alimentos(int id, string marca, decimal valor, DateTime validade, int qtdEstoque)
        {
            ID = 3;
            Marca = "Friboi";
            ValorUnit = 40.99m;
            QtdEstoque = 30;
            Validade = new DateTime(08 / 10 / 2020).Date;
        }

        public void MateriaisEscolares(int id, string marca, decimal valor, int qtdEstoque, string tipo)
        {
            throw new NotImplementedException();
        }

        public void Vestimentas(int id, string marca, decimal valor, int qtdEstoque, string material)
        {
            throw new NotImplementedException();
        }
    }
}
