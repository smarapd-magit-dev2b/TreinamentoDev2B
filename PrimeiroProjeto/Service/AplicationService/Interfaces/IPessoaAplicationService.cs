using Commom.Dto;
using System.Collections.Generic;

namespace Service.AplicationService.Interfaces
{
    public interface IPessoaAplicationService
    {
        List<PessoaGetDto> Get();
        PessoaGetDto GetPorCodigo(int codigo);
        int Post(PessoaPostDto pessoaDto);
        int Put(int codigo, PessoaPostDto pessoaDto);
        int Delete(int codigo);
        int PutUsuarioAtivo(int codigo, bool usuario);
        int PutEssencial(int codigo, PessoaPutEssencialDto pessoaDto);
    }
}
