using System;
using System.Collections.Generic;
using System.Text;

namespace Aula08._SOLID.ClassesAula08.ExemploRuim
{
    public class Roupas : ILoja
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public decimal ValorUnit { get; set; }
        public int QtdEstoque { get; set; }
        public string Material { get; set; }

        public void Alimentos(int id, string marca, decimal valor, DateTime validade, int qtdEstoque)
        {
            throw new NotImplementedException();
        }
        public void MateriaisEscolares(int id, string marca, decimal valor, int qtdEstoque, string tipo)
        {
            throw new NotImplementedException();
        }
        public void Vestimentas(int id, string marca, decimal valor, int qtdEstoque, string material)
        {
            ID = 1;
            Marca = "Polo";
            ValorUnit = 100.00m;
            QtdEstoque = 50;
            Material = "Algodão";
        }
    }
}
