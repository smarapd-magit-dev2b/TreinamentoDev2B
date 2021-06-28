using Aula04.Classes;
using System;

namespace Aula04
{
    public class Heranca
    {
        public void Execute()
        {
            Ex1();
            

        }

        static void Ex1()
        {
            Fornecedor fornecedor = new Fornecedor("Universo Baterias", "Prudente de Morais", "36286001", "981280829", "25455", "automotivo", "baterias");
            fornecedor.EscreverInformacoes();

           
            Cliente cliente = new Cliente("Amanda Jaria", "Avenida Portugal", "251151", "88524", "8712654", "4712", 0, "Solteira");
            cliente.EscreverInformacoes();

            
            Funcionario funcionario = new Funcionario("Fulvia Oliveira", "Travessa da União", "842555", "23254", "7888", "878855", 1, "Divorciada", 1500, "158444", DateTime.Now);
            funcionario.EscreverInformacoes();

        }
    }
}
