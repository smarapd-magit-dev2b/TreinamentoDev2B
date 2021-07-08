using System;

namespace Commom.Exceptions
{
    public class NegocioException : Exception
    {
        public NegocioException(string message) : base(message) { }
    }
}
