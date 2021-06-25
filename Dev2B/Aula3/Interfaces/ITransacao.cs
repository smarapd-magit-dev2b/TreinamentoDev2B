using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Interfaces
{
    public interface ITransacao
    {
        public abstract void ImpreExtrato();
        public string Depositar();
        public string Sacar();
    }
}
