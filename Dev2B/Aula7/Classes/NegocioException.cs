using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7.Classes
{
    public class NegocioException : Exception
    {
        public NegocioException(string message) : base(message)
        {
        }
    }
}
