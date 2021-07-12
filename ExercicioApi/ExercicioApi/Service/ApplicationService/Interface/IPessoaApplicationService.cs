using Common.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.ApplicationService.Interface
{
    public interface IPessoaApplicationService
    {
        int AdicionarPessoa(AddPessoaDto dto);
        void AtivarUsuario(int id);
        void DeletarPessoa(int id);
        void EditNomeSobrenomeCpf(int id, EditNomeSobrenomeCpfDto dto);
        void EditPessoa(int id, EditPessoaDto dto);
        List<PessoaGetAllDto> GetAll();
        PessoaGetByIdDto GetById(int id);
    }
}
