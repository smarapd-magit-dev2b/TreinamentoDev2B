using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_8.SOLID
{
    //Princípio Aberto e Fechado (OCP)
    public abstract class Dispositivo : IStatus
    {
        public bool Status { get; set; }

        public Dispositivo() => Status = false;
    }
}
