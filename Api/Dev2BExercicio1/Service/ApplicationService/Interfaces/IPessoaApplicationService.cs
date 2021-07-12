using System.Collections.Generic;
using Common.Dtos;

namespace Service.ApplicationService.Interfaces
{
    public interface IPessoaApplicationService
    {
        int AdicionarPessoa(PessoaPostDto postDto);
        void EditarPessoa(int id, PessoaPutDto putDto);
        void DeletarPessoa(int id);
        PessoaGetAllDto GetPessoaId(int id);
        List<PessoaGetAllDto> GetAll();
    }
}
