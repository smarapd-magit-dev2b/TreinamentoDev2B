using System;
using System.Collections.Generic;
using System.Linq;
using Common.Entities;
using Infrastructure.Repository.Interfaces;

namespace Infrastructure.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private List<Pessoa> PessoaCollection = new List<Pessoa>
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
                    UsuarioAtivo = true,
                    Filhos = new List<Pessoa>()
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
                    UsuarioAtivo = true,
                    Filhos = new List<Pessoa>()
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
                    Filhos = new List<Pessoa>()
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
                    Filhos = new List<Pessoa>()
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
                    Filhos = new List<Pessoa>()
                }
            };

        public void Adicionar(Pessoa pessoa)
        {
            PessoaCollection.Add(pessoa);
        }

        public void AdicionarFilho(int id, Pessoa filho)
        {
            var AddFilhos = PessoaCollection.Where(x => x.Id == id).FirstOrDefault();
            AddFilhos.Filhos.Add(filho);
        }

        public void AtivarUsuario(int id)
        {
            var ativaUsuario = PessoaCollection.Where(x => x.Id == id).FirstOrDefault();
            ativaUsuario.UsuarioAtivo = true;
        }

        public void Atualizar(int id, Pessoa pessoa)
        {
            var pessoaEdit = PessoaCollection.Where(x => x.Id == id).FirstOrDefault();
            pessoaEdit.Nome = pessoa.Nome;
            pessoaEdit.SobreNome = pessoa.SobreNome;
            pessoaEdit.Cpf = pessoa.Cpf;
        }

        public void Deletar(Pessoa pessoa)
        {
            PessoaCollection.Remove(pessoa);
        }

        public void DesativarUsuario(int id)
        {
            var desativaUsuario = PessoaCollection.Where(x => x.Id == id).FirstOrDefault();
            desativaUsuario.UsuarioAtivo = false;
        }

        public void Editar(int id, Pessoa pessoa)
        {
            var pessoaEdit = PessoaCollection.Where(x => x.Id == id).FirstOrDefault();
            pessoaEdit.Nome = pessoa.Nome;
            pessoaEdit.SobreNome = pessoa.SobreNome;
            pessoaEdit.Cpf = pessoa.Cpf;
            pessoaEdit.Altura = pessoa.Altura;
            pessoaEdit.DataNascimento = pessoa.DataNascimento;
            pessoaEdit.Peso = pessoa.Peso;
            pessoaEdit.Raca = pessoa.Raca;
        }

        public List<Pessoa> GetAll()
        {
            return PessoaCollection;
        }

        public Pessoa ObterPessoaPorId(int id)
        {
            var pessoa = PessoaCollection.Where(x => x.Id == id).FirstOrDefault();
            return pessoa;
        }
    }
}
