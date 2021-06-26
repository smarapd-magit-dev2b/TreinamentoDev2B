﻿using Aula3;
using Domain;
using System;

namespace Aula2
{
    public class Professor : Funcionario
    {
        public int Registro { get; set; }
        public Disciplina Disciplina { get; set; }
        public Professor()
        {
            DataNascimento = new Data();
            Disciplina = new Disciplina();
            DataAdmissao = new Data();
        }
        public void ImprimirDados()
        {
            Console.WriteLine("Professor");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Data de nascimento: {DataNascimento.ToUserString()}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Nacionalidade: {Nacionalidade}");
            Console.WriteLine($"Cidade: {Endereco.Cidade}");
            Console.WriteLine($"Estado: {Endereco.Estado}");
            Console.WriteLine($"CNH: {Cnh}");
            Console.WriteLine($"Data de admissão: {DataAdmissao.ToUserString()}");
            Console.WriteLine($"Registro: {Registro}");
            Console.WriteLine($"Salario: R${Salario}\n");
            Disciplina.ImprimirDados();
        }
    }
}
