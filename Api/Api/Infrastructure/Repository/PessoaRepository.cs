using Domain.Entities;
using Infrastructure.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private List<Pessoa> _pessoa;
        public void Adicionar(Pessoa pessoa)
        {
            _pessoa.Add(pessoa);
        }

        public List<Pessoa> GetAll()
        {
            return _pessoa;
        }
    }
}
