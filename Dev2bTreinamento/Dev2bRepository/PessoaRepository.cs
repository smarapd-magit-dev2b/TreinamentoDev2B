using Dev2bDomain.Entities;
using Dev2bDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dev2bRepository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly List<PessoaEntity> pessoas;

        public PessoaRepository()
        {
            pessoas = new List<PessoaEntity>
            {
                new PessoaEntity
                {
                    Id = 1,
                    Nome = "José",
                    Altura = 1.9m,
                    DataNascimento = new DateTime(1993, 12, 9),
                    Peso = 80.0m,
                    Raca = "Branca",
                    Idade = 18,
                    UsuarioAtivo = true
                },
                new PessoaEntity
                {
                    Id = 10,
                    Nome = "Willian",
                    Altura = 1.7m,
                    DataNascimento = new DateTime(1950, 10, 4),
                    Peso = 100.0m,
                    Raca = "Negro",
                    Idade = 25,
                    UsuarioAtivo = true
                },
                new PessoaEntity
                {
                    Id = 4,
                    Nome = "Silas",
                    Altura = 1.78m,
                    DataNascimento = new DateTime(1968, 2, 2),
                    Peso = 92.0m,
                    Raca = "Branca",
                    Idade = 35,
                    UsuarioAtivo = true,
                },
                new PessoaEntity
                {
                    Id = 77,
                    Nome = "Glenison",
                    Altura = 1.89m,
                    DataNascimento = new DateTime(1991, 6, 28),
                    Peso = 75,
                    Raca = "Branca",
                    Idade = 30,
                    UsuarioAtivo = false
                },
                new PessoaEntity
                {
                    Id = 90,
                    Nome = "Gabriel",
                    Altura = 1.89m,
                    DataNascimento = new DateTime(1991, 6, 28),
                    Peso = 75,
                    Raca = "Branca",
                    Idade = 30,
					UsuarioAtivo = true
                }
            };
        }

        public List<PessoaEntity> ObterTodosOsPessoas()
        {
            if (pessoas == null || !pessoas.Any())
                return null;

            return pessoas;
        }

        public PessoaEntity ObterPessoaPorId(int id)
        {
            var pessoa = pessoas.FirstOrDefault(p => p.Id == id);

            if (pessoa == null)
                return null;

            return pessoa;
        }

        public void AdicionarPessoa(PessoaEntity pessoa) => pessoas.Add(pessoa);

        public void AlterarPessoa(int id, PessoaEntity pessoa)
        {
            var indice = pessoas.IndexOf(pessoas.FirstOrDefault(p => p.Id == id));
            pessoas[indice] = pessoa;
        }

        public void DeletarPessoa(int id) => pessoas.Remove(pessoas.FirstOrDefault(c => c.Id == id));
    }
}
