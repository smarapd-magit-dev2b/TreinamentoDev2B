﻿using System;
using Aula1;
using Aula2;
using Aula3;
using Aula5;
using Aula6;
using Aula7;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            EstruturasComando estruturasComando = new EstruturasComando();
            ClassesObjetos classesObjetos = new ClassesObjetos();
            Herancas herancas = new Herancas();
            ClassesAbstrata classesAbstrata = new ClassesAbstrata();
            ColecoesListas colecoes = new ColecoesListas();
            ExpressoesLambdas expressoesLambdas = new ExpressoesLambdas();
            ExcecoesTryCatch excecoesTryCatch = new ExcecoesTryCatch();

            estruturasComando.Execute();
            classesObjetos.Execute();
            herancas.Execute();
            classesAbstrata.Execute();
            colecoes.Execute();
            expressoesLambdas.Execute();
            excecoesTryCatch.Execute();
        }
    }
}
