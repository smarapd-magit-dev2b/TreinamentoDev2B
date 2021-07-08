using System;
using System.Collections.Generic;
using System.Text;

namespace Aula08._SOLID.ClassesAula08.ExemploRuim
{
    public interface ILoja
    {
        public void Vestimentas(int id, string marca, decimal valor, int qtdEstoque, string material);
        public void MateriaisEscolares(int id, string marca, decimal valor, int qtdEstoque, string tipo);
        public void Alimentos(int id, string marca, decimal valor, DateTime validade, int qtdEstoque);

    }
}

