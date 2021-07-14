using System.Collections.Generic;
using Common.Dto;

namespace Service.ApplicationService.Interfaces
{
    public interface IPessoaApplicationService
    {
        int AddPessoa(PessoaPostDto dto);
        int AddFilho(int id, PessoaFilhosPutDto putFilhoDto);
        void DeletePessoa(int id);
        void EditPessoa(int id, PessoaPutDto putDto);
        void EditInfoPessoa(int id, PessoaEditInfoPutDto patchDto);
        void EnableUser(int id);
        void DisableUser(int id);
        PessoaGetAllDto GetPessoaId(int id);
        List<PessoaGetAllDto> GetAll();
    }
}
