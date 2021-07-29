using Commom.Dto.Product;
using System.Collections.Generic;

namespace Service.AplicationService.Interfaces
{
    public interface IProductAplicationService
    {
        IEnumerable<ProductGetDto> Get();
        ProductGetDto Get(int id);
        int Post(ProductPostDto dto);
        void Put(int id, ProductPostDto dto);
        void Delete(int id);
    }
}
