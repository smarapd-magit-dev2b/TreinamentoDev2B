using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_8.SOLID
{
    public class Carro : IStatus
    {
        public bool Status { get; set; }
        public Carro() => Status = false;
    }
}
