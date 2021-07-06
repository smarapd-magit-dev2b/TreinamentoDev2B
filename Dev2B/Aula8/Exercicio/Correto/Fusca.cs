﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7.Correto
{
    public class Fusca : Carro
    {
        public Fusca(string marca, int anoLancamento, string cor, decimal valorCarro) : base(marca, anoLancamento, cor, valorCarro)
        {
        }

        public override decimal ValorIpva()
        {
            return  ValorCarro * .1m;
        }
    }
}
