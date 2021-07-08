using System;
using System.Collections.Generic;
using System.Text;

namespace Aula07_ClassesEstaticas.ClassesAula07
{
        public class NegocioException : Exception
        {
            public NegocioException(string message) : base(message)
            {
            }
        }
}
