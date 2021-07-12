using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Infrastructure.Repository.Interfaces;

namespace Infrastructure.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        List<Pessoa> PessoaCollection = new List<Pessoa>
        {
                new Pessoa
                {
                    Id = 1,
                    Nome = "José",
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
                    Altura = 1.89m,
                    DataNascimento = new DateTime(1991, 6, 28),
                    Peso = 75,
                    Raca = "Branca",
                    UsuarioAtivo = false
                },
                new Pessoa
                {
                    Id = 90,
                    Nome = "Gabriel",
                    Altura = 1.89m,
                    DataNascimento = new DateTime(1991, 6, 28),
                    Peso = 75,
                    Raca = "Branca",
                    UsuarioAtivo = true
                }
        };

        public void Adicionar(Pessoa pessoa)
        {
            PessoaCollection.Add(pessoa);
        }

        public void Deletar(Pessoa pessoa)
        {
            PessoaCollection.Remove(pessoa);
        }

        public void Editar(int id, Pessoa pessoa)
        {
            var pessoaEdit = PessoaCollection.Where(x => x.Id == id).FirstOrDefault();
            pessoaEdit.Nome = pessoa.Nome;
            pessoaEdit.Altura = pessoa.Altura;
            pessoaEdit.DataNascimento = pessoa.DataNascimento;
            pessoaEdit.Peso = pessoa.Peso;
            pessoaEdit.Raca = pessoa.Raca;
        }

        public List<Pessoa> GetAll()
        {
            return PessoaCollection;
        }

        public Pessoa GetPessoaPorId(int id)
        {
            var pessoa = PessoaCollection.Where(x => x.Id == id).FirstOrDefault();
            return pessoa;
        }
    }
}
