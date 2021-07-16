using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_7.Exercicio_1
{
    public class Erro : Exception
    {
        public override string Message => "\nErro: não existe pais nem filhos com mais de 90 anos\n";


    }
}
