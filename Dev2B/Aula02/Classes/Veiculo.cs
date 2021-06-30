using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Classes
{
    public class Veiculo
    {
        //atributos
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private string Cor { get; set; }
        private int Ano { get; set; }
        private int Num_portas { get; set; }
        private int Chassi { get; set; }
        private string Proprietario { get; set; }
        private float Velocidade_max { get; set; }
        private float Velocidade_atual { get; set; }
        private int Qtde_marchas { get; set; }
        private int Marcha_atual { get; set; }    
    


        //construtor

        public Veiculo()
        {
        }

        public Veiculo(string marca, string modelo, string cor, int ano, int num_portas, int chassi, string proprietario, float velocidade_max, float velocidade_atual, int qtde_marchas, int marcha_atual)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
            Num_portas = num_portas;
            Chassi = chassi;
            Proprietario = proprietario;
            Velocidade_max = velocidade_max;
            Velocidade_atual = velocidade_atual;
            Qtde_marchas = qtde_marchas;
            Marcha_atual = marcha_atual;

        }

        //métodos

        public void acelerarVeiculo()
        {
            Velocidade_atual += 10;
            Console.WriteLine("velocidade atual: " + Velocidade_atual);
        }

        public void frearVeiculo()
        {
            Velocidade_atual = 0;
            Console.WriteLine("velocidade atual: " + Velocidade_atual);
        }

        //public void alterarMarcha()
        //{
        //    int var = 0;


        //    if (var < 0 || var > this.qtde_marchas)
        //    {
        //        throw new Exception("Marcha inválida");
        //    }
        //    else if (var == 0 && this.velocidade_atual > 0)
        //    {
        //        throw new Exception("Reduza para zero antes da ré");
        //    }
        //    else
        //    {
        //        this.marcha_atual = var;
        //        Console.WriteLine("marcha atual" + Marcha_atual);
        //    }
        //}


        //public void imprimirVeiculo()
        //{
        //    Console.WriteLine("--------------------VEÍCULO-------------------------- ");
        //    Console.WriteLine("marca: " + Marca);
        //    Console.WriteLine("modelo: " + Modelo);
        //    Console.WriteLine("cor: " + Cor);
        //    Console.WriteLine("ano: " + Ano);
        //    Console.WriteLine("numero de portas: " + Num_portas);
        //    Console.WriteLine("chassi: " + Chassi);
        //    Console.WriteLine("proprietario: " + Proprietario);
        //    Console.WriteLine("velocidade maxima: " + Velocidade_max);
        //    Console.WriteLine("velocidade atual: " + Velocidade_atual);
        //    Console.WriteLine("qtde marchas: " + Qtde_marchas);
        //    Console.WriteLine("marcha atual: " + Marcha_atual);

        //}
    }
}
