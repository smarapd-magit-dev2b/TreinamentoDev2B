using System;
using System.Collections.Generic;
using System.Text;

namespace Aluno
{
    public class DadosPessoa
    {
        /*Exercício 1
        Implemente a seguinte classe:
        Pessoa
        Atributos: Nome, Telefone, Data de Nascimento, Salário, Quantidade de Filhos, Altura,
        Peso, Nome do Pai, Nome da Mãe.
        Escreva um aplicativo de teste onde seja possível cadastrar várias pessoas utilizando a
        classe mencionada acima.O aplicativo deverá ter os seguintes mecanismos:
        - Cadastrar uma nova pessoa
        - Listar o nome de todas as pessoas cadastradas*/

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }
        public int QntdFilhos { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }



        public override string ToString()
        {
            return $"Nome: {Nome}. Telefone: {Telefone}. Salário: {Salario}. Nasc.: {DataNascimento.ToString("dd/MM/yyyy")}.\nQuantidade de filhos: {QntdFilhos}. Peso: {Peso}. Altura: {Altura}.\nNome do Pai: {NomePai}. Nome da Mãe: {NomeMae}.";
        }

    }
}
