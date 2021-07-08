using Commom.Dto;
using System.Collections.Generic;

namespace Service.AplicationService.Interfaces
{
    public interface IPessoaAplicationService
    {
        List<PessoaGetDto> GetAllDtos();
        PessoaGetDto GetDtoPorId(int id);
        int PostDto(PessoaPostDto pessoaDto);
        int PutDto(int id, PessoaPostDto pessoaDto);
    }
}
