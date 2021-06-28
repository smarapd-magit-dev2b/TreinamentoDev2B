using Aula04.Classes;
using System;

namespace Aula04
{
    public class Heranca
    {
        public void Execute()
        {
            Ex1();
            Ex2();
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

        static void Ex2()
        {
            Console.WriteLine("Informações Aviao\n\n");
            Aviao aviao = new Aviao("Branco", 1000m, "Diesel", "Boing", 200, 8, 2, "Grande");
            aviao.EscreverDadosEspecificos();


            Console.WriteLine("\n\nInformações Carro\n\n");
            Carro carro = new Carro("Preto", 200m, "Alcool", "Gol", 4, 4, true, true, 2);
            carro.EscreverDadosEspecificos();


            Console.WriteLine("\n\nInformações Moto\n\n");
            Moto moto = new Moto("Preto", 100m, "Alcool", "Kawasaki", 2, 2, false);
            moto.EscreverDadosEspecificos();
                      

        }
    }
}
