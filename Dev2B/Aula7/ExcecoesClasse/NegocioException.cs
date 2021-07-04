using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7.ExcecoesClasse
{
    public class NegocioException : Exception
    {
        public NegocioException(string message) : base(message)
        {

        }
    }
}
