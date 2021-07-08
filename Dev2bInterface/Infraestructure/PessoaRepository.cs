using Domain.Entities;
using Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private List<Pessoa> Pessoa = new List<Pessoa>
            {
                new Pessoa
                {
                    Id = 1,
                    Nome = "José",
                    SobreNome = "Silva",
                    Cpf = "497.500.270-19",
                    Altura = 1.9m,
                    DataNascimento = new DateTime(1993, 12, 9),
                    Peso = 80.0m,
                    Raca = "Branca",
                    UsuarioAtivo = true
                },
                new Pessoa
                {
                    Id = 10,
                    Nome = "Willian",
                    SobreNome = "Andrade",
                    Cpf = "009.630.700-53",
                    Altura = 1.7m,
                    DataNascimento = new DateTime(1950, 10, 4),
                    Peso = 100.0m,
                    Raca = "Negro",
                    UsuarioAtivo = true
                },
                new Pessoa
                {
                    Id = 4,
                    Nome = "Silas",
                    SobreNome = "Almeida",
                    Cpf = "164.656.030-20",
                    Altura = 1.78m,
                    DataNascimento = new DateTime(1968, 2, 2),
                    Peso = 92.0m,
                    Raca = "Branca",
                    UsuarioAtivo = true,
                },
                new Pessoa
                {
                    Id = 77,
                    Nome = "Glenison",
                    SobreNome = "Honório",
                    Cpf = "916.876.230-58",
                    Altura = 1.89m,
                    DataNascimento = new DateTime(1991, 6, 28),
                    Peso = 75,
                    Raca = "Branca",
                    UsuarioAtivo = false,
                },
                new Pessoa
                {
                    Id = 90,
                    Nome = "Gabriel",
                    SobreNome = "Domingos",
                    Cpf = "421.694.740-99",
                    Altura = 1.89m,
                    DataNascimento = new DateTime(1991, 6, 28),
                    Peso = 75,
                    Raca = "Branca",
                    UsuarioAtivo = true,
                }
            };

        public void Adicionar(Pessoa pessoa)
        {
            Pessoa.Add(pessoa);
        }

        public List<Pessoa> GetAll()
        {
            return Pessoa;
        }
    }
}
