using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Dto;

namespace Infrastructure.Repository.Interface
{
    public interface IPessoaRepository
    {
        int AddPessoa(Pessoa pessoa);
        void AtivarUsuario(int id);
        void DeletePessoa(int id);
        void EditPessoa(int id, Pessoa pessoa);
        List<Pessoa> GetAll();
        Pessoa GetById(int id);
    }
}
