using Common.Dto;
using System.Collections.Generic;
using System.Text;

namespace Service.ApplicationService.Interface
{
    public interface IPessoaApplicationService
    {
        int AdicionarPessoa(PessoaPostDto pessoa);
        List<PessoaGetAllDto> GetAll();
        List<PessoaGetAllCpfDto> GetAllCpf();
    }
}
