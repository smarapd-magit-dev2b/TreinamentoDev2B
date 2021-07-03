using Domain.Classes;
using Domain.Interfaces;
using Aula7.Exercicios;
using System;

namespace Aula7
{
    public class TryCatchEStatic : IExecute
    {
        public void Execute()
        {
            Menu menu = new Menu("Try/Catch e Static");
            menu.AddItem(new Exercicio1());
            try
            {
                new Exercicio1();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Console.WriteLine("Exercicio feito.");
            }
            
        }
    }
}
