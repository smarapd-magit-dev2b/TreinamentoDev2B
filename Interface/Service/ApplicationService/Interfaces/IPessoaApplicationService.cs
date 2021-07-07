using Commom.Dto;
using System.Collections.Generic;

namespace Service.ApplicationService.Interfaces
{
    public interface IPessoaApplicationService
    {
        int Adicionarpessoa(PessoaPostDto pessoa);
        List<PessoaGetAllDto> GetAll();
    }
}
