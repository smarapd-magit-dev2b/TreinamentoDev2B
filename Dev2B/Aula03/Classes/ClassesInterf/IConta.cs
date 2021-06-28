using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Classes.ClassesInterf
{
    public interface IConta
    {
        public void ImpreExtrato();
        public void Depositar(decimal valor);
        public void Sacar(decimal valor);
    }
}
