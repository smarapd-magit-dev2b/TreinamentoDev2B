using System.Collections.Generic;
using Common.Dto;

namespace Service.ApplicationService.Interfaces
{
    public interface IPessoaApplicationService
    {
        int AdicionarPessoa(PessoaPostDto dto);
        void AdicionarFilho(int id, PessoaFilhosPutDto putFilhoDto);
        void DeletarPessoa(int id);
        void EditarPessoa(int id, PessoaPutDto putDto);
        void AtualizarPessoa(int id, PessoaPatchDto patchDto);
        void AtivarUsuario(int id);
        void DesativarUsuario(int id);
        PessoaGetAllDto GetPessoaId(int id);
        List<PessoaGetAllDto> GetAll();
    }
}
