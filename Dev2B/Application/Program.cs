﻿using Aula1;
using Aula2;
using Aula3;
using Aula5;
using System;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EstruturasDeComando estruturasDeComando = new EstruturasDeComando();
            //ClassesObjeto classesObjeto = new ClassesObjeto();
            //HerancaAbstrataInterface herancaAbstrataInterface = new HerancaAbstrataInterface();
            ColecoesLista colecoesLista = new ColecoesLista();

            //estruturasDeComando.Executar();
            //classesObjeto.Executar();
            //herancaAbstrataInterface.Executar();
            colecoesLista.Executar();
        }
    }
}
