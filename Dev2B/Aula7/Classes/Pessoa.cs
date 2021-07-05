using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7.Classes
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string Raca { get; set; }
        public Endereco Endereco { get; set; }
        public List<Pessoa> Filhos { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}. \nNome: {Nome}. \nData de nascimento: {DataNascimento.ToString("dd/MM/yyyy")}." +
                   $" \nAltura: {Altura}. \nPeso: {Peso}. \nRaca: {Raca}." +
                   $"\nLogradouro: {Endereco.Logradouro}. \nNumero: {Endereco.Numero}" +
                   $". \nComplemento: {Endereco.Complemento}. \nBairro: {Endereco.Bairro}\n\n";
        }
    }
}
