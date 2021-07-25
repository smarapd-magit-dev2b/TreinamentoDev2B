using System.Collections.Generic;
using Common.Dto;

namespace Service.ApplicationService.Interfaces
{
    public interface IProdutoApplicationService
    {
        IEnumerable<ProdutoGetAllDto> GetAll();
        ProdutoGetAllDto GetById(int id);
        int Post(ProdutoPostDto produtoPostDto);
        void Put(int id, ProdutoPutDto produtoPutDto);
        void Delete(int id);
    }
}
