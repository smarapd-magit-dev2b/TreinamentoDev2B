using System;
using System.Collections.Generic;
using System.Text;

namespace Aula08._SOLID.ClassesAula08.ExemploRuim
{
    public class Papelaria : ILoja
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public decimal ValorUnit { get; set; }
        public int QtdEstoque { get; set; }
        public string Tipo { get; set; }

        public void MateriaisEscolares()
        {
           
        }

        public void Vestimentas(int id, string marca, decimal valor, int qtdEstoque, string material)
        {
            throw new NotImplementedException();
        }

        public void MateriaisEscolares(int id, string marca, decimal valor, int qtdEstoque, string tipo)
        {

            ID = 2;
            Marca = "Faber Castel";
            ValorUnit = 20.00m;
            QtdEstoque = 300;
            Tipo = "Lápis de cor";
            
        }

        public void Alimentos(int id, string marca, decimal valor, DateTime validade, int qtdEstoque)
        {
            throw new NotImplementedException();
        }
    }
}
