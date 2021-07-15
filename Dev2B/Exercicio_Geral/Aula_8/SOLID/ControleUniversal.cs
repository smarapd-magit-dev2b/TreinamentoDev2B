using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_8.SOLID
{
    public static class ControleUniversal
    {
        //Princípio de Substituição de Liskov
        public static void Ligar(IStatus unidade) => unidade.Status = true;
        public static void Desligar(IStatus unidade) => unidade.Status = false;
    }
}
