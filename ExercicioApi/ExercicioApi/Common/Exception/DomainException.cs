using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Exception
{
    public class DomainException : System.Exception
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
