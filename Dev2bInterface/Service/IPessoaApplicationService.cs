using Common.Dto;
using System.Collections.Generic;

namespace Service.ApplicationService.Interfaces
{
    public interface IPessoaApplicationService
    {
        int Cadastrar(PessoaPostDto pessoa);
        void CadastrarFilhos(int id, PessoaFilhosDto pessoaDto);
        List<PessoaGetAllDto> Listar();
        int Deletar(int id);
        List<PessoaGetIdDto> ListarPessoaPorID(int id);
        int EditarId(int id, PessoaPutIdDto pessoa);
        int EditarPutBasicDto(int id, PessoaPutBasicDto pessoaDto);
        int StatusUsuario(int id);
    }
}
