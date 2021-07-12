using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository.Interface
{
    public interface IPessoaRepository
    {
        void Adicionar(Pessoa pessoa);
        List<Pessoa> GetAll();
    }
}
