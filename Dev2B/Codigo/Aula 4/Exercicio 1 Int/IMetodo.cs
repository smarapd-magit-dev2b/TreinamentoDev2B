using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_1Inter
{
    public interface IMetodo
    {

        public abstract void ImprimeExtr();

        public abstract decimal Depositar(decimal deposito);

        public abstract decimal Sacar(decimal saque);


    }
}
