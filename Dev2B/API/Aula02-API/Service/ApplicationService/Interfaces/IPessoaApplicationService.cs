using Common.DTO;
using System.Collections.Generic;

namespace Service.ApplicationService.Interfaces {
    public interface IPessoaApplicationService {
        int Cadastrar(PessoaPostDTO pessoa);
        void CadastrarFilhos(int id, PessoasFilhosDTO pessoaDTO);
        List<PessoaGetAllDTO> Listar();
        int Deletar(int id);
        List<PessoaGetIdDTO> ListarPessoaPorID(int id);
        int Editar(int id, PessoaPutDTO pessoa);
        int EditarNomeSobrenomeCpf(int id, PessoaNomeSobrenomeCpfPatchDTO pessoaDTO);
        int StatusUsuario(int id);
    }
}
