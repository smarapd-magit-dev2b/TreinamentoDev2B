using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.Interfaces
{
    public interface IConta
    {
        public void ImpreExtrato();
        public void Depositar(decimal valor);
        public void Sacar(decimal valor);
    }
}
