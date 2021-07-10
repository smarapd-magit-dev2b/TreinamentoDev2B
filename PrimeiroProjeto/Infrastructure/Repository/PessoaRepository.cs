using Domain.Entities;
using Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly List<Pessoa> _pessoas = new List<Pessoa>
            {
                new Pessoa
                {
                    Id = 1,
                    Name = "José",
                    LastName = "Silva",
                    Cpf = "497.500.270-19",
                    Height = 1.9m,
                    BirthDate = new DateTime(1993, 12, 9),
                    Weight = 80.0m,
                    Race = "Branca",
                    Status = true
                },
                new Pessoa
                {
                    Id = 2,
                    Name = "Willian",
                    LastName = "Andrade",
                    Cpf = "009.630.700-53",
                    Height = 1.7m,
                    BirthDate = new DateTime(1950, 10, 4),
                    Weight = 100.0m,
                    Race = "Negro",
                    Status = true
                },
                new Pessoa
                {
                    Id = 3,
                    Name = "Silas",
                    LastName = "Almeida",
                    Cpf = "164.656.030-20",
                    Height = 1.78m,
                    BirthDate = new DateTime(1968, 2, 2),
                    Weight = 92.0m,
                    Race = "Branca",
                    Status = true,
                },
                new Pessoa
                {
                    Id = 4,
                    Name = "Glenison",
                    LastName = "Honório",
                    Cpf = "916.876.230-58",
                    Height = 1.89m,
                    BirthDate = new DateTime(1991, 6, 28),
                    Weight = 75,
                    Race = "Branca",
                    Status = false
                },
                new Pessoa
                {
                    Id = 5,
                    Name = "Gabriel",
                    LastName = "Domingos",
                    Cpf = "421.694.740-99",
                    Height = 1.89m,
                    BirthDate = new DateTime(1991, 6, 28),
                    Weight = 75,
                    Race = "Branca",
                    Status = true
                }
            };
        #region Get
        public List<Pessoa> Get() => _pessoas != null && _pessoas.Any() ? _pessoas : null;

        public Pessoa GetPorId(int id) => _pessoas.FirstOrDefault(p => p.Id == id) ?? null;
        #endregion
        #region Post
        public int Post(Pessoa pessoa)
        {
            _pessoas.Add(pessoa);

            return _pessoas.Last().Id;
        }

        public int Post(int idPai, int idFilho)
        {
            Pessoa pai = _pessoas[_pessoas.IndexOf(_pessoas.First(p => p.Id == idPai))];

            if (pai.Filhos == null)
                pai.Filhos = new List<Pessoa>();

            pai.Filhos.Add
            (
                _pessoas
                [
                    _pessoas.IndexOf
                    (
                        _pessoas.First(p => p.Id == idFilho)
                    )
                ]
            );

            return idFilho;
        }
        #endregion
        #region Put
        public int Put(int id, Pessoa pessoa)
        {
            _pessoas[_pessoas.IndexOf(_pessoas.First(p => p.Id == id))] = pessoa;

            return id;
        }

        public int PutPessoaEssencial(int id, Pessoa pessoa)
        {
            int indice = _pessoas.IndexOf(_pessoas.First(p => p.Id == id));

            _pessoas[indice].Name = pessoa.Name;
            _pessoas[indice].LastName = pessoa.LastName;
            _pessoas[indice].Cpf = pessoa.Cpf;

            return id;
        }

        public int PutStatus(int id, bool status)
        {
            _pessoas[_pessoas.IndexOf(_pessoas.First(p => p.Id == id))].Status = status;

            return id;
        }
        #endregion
        public int Delete(int id)
        {
            _pessoas.RemoveAll(p => p.Id == id);

            return id;
        }
    }
}
