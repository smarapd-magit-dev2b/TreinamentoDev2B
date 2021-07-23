using System;
using System.Collections.Generic;
using System.Linq;
using Common.Entities;
using Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly Context _dbContext;

        public PessoaRepository(Context dbContext)
        {
            _dbContext = dbContext;
        }

        //private List<Pessoa> PessoaCollection = new List<Pessoa>
        //    {
        //        new Pessoa
        //        {
        //            Id = 1,
        //            Nome = "José",
        //            SobreNome = "Silva",
        //            Cpf = "497.500.270-19",
        //            Altura = 1.9m,
        //            DataNascimento = new DateTime(1993, 12, 9),
        //            Peso = 80.0m,
        //            Raca = "Branca",
        //            UsuarioAtivo = true,
        //            Filhos = new List<Pessoa>()
        //        },
        //        new Pessoa
        //        {
        //            Id = 10,
        //            Nome = "Willian",
        //            SobreNome = "Andrade",
        //            Cpf = "009.630.700-53",
        //            Altura = 1.7m,
        //            DataNascimento = new DateTime(1950, 10, 4),
        //            Peso = 100.0m,
        //            Raca = "Negro",
        //            UsuarioAtivo = true,
        //            Filhos = new List<Pessoa>()
        //        },
        //        new Pessoa
        //        {
        //            Id = 4,
        //            Nome = "Silas",
        //            SobreNome = "Almeida",
        //            Cpf = "164.656.030-20",
        //            Altura = 1.78m,
        //            DataNascimento = new DateTime(1968, 2, 2),
        //            Peso = 92.0m,
        //            Raca = "Branca",
        //            UsuarioAtivo = true,
        //            Filhos = new List<Pessoa>()
        //        },
        //        new Pessoa
        //        {
        //            Id = 77,
        //            Nome = "Glenison",
        //            SobreNome = "Honório",
        //            Cpf = "916.876.230-58",
        //            Altura = 1.89m,
        //            DataNascimento = new DateTime(1991, 6, 28),
        //            Peso = 75,
        //            Raca = "Branca",
        //            UsuarioAtivo = false,
        //            Filhos = new List<Pessoa>()
        //        },
        //        new Pessoa
        //        {
        //            Id = 90,
        //            Nome = "Gabriel",
        //            SobreNome = "Domingos",
        //            Cpf = "421.694.740-99",
        //            Altura = 1.89m,
        //            DataNascimento = new DateTime(1991, 6, 28),
        //            Peso = 75,
        //            Raca = "Branca",
        //            UsuarioAtivo = true,
        //            Filhos = new List<Pessoa>()
        //        }
        //    };

        public void Add(Pessoa pessoa)
        {
            _dbContext.Pessoas.Add(pessoa);
            _dbContext.SaveChanges();
        }

        public void EnableUser(Pessoa pessoa)
        {
            //var enableUser = _dbContext.Pessoas.Where(x => x.Id == id).FirstOrDefault();
            //enableUser.UsuarioAtivo = true;
            _dbContext.Pessoas.Update(pessoa);
            _dbContext.SaveChanges();
        }

        public void EditInfo(Pessoa pessoa)
        {
            //var pessoaEditInfo = _dbContext.Pessoas.Where(x => x.Id == id).FirstOrDefault();
            _dbContext.Pessoas.Update(pessoa);
            _dbContext.SaveChanges();
        }

        public void Delete(Pessoa pessoa)
        {
            _dbContext.Pessoas.Remove(pessoa);
            _dbContext.SaveChanges();
        }

        public void DisableUser(Pessoa pessoa)
        {
            //var disableUser = _dbContext.Pessoas.Where(x => x.Id == id).FirstOrDefault();
            //disableUser.UsuarioAtivo = false;
            _dbContext.Pessoas.Update(pessoa);
            _dbContext.SaveChanges();
        }

        public void Edit(Pessoa pessoa)
        {
            //var pessoaEdit = _dbContext.Pessoas.Where(x => x.Id == id).FirstOrDefault();
            _dbContext.Pessoas.Update(pessoa);
            _dbContext.SaveChanges();

        }

        public List<Pessoa> GetAll()
        {
            return _dbContext.Pessoas.AsNoTracking().ToList();
        }

        public int GetNextId()
        {
            return _dbContext.Pessoas.Union(_dbContext.Pessoas.Where(pessoa => pessoa.Filhos != null).SelectMany(p => p.Filhos)).Max(x => x.Id) + 1;
        }

        public Pessoa GetPessoaById(int id)
        {
            var pessoaId = _dbContext.Pessoas.AsNoTracking().FirstOrDefault(x => x.Id == id);
            return pessoaId;
        }
    }
}
