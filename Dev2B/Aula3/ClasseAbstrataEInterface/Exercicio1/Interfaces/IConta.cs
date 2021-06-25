using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3.Exercicio4.Classes
{
    public interface IConta
    {
        public void ImpreExtrato();
        public void Depositar(decimal valor);
        public void Sacar(decimal valor);
    }
}
