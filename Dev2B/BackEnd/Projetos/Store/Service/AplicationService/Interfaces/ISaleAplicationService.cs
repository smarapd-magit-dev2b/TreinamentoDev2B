using Commom.Dto.Sale;
using Commom.Dto.SaleItem;
using System.Collections.Generic;

namespace Service.AplicationService.Interfaces
{
    public interface ISaleAplicationService
    {
        IEnumerable<SaleGetDto> Get();
        int Post(int customerId, IEnumerable<SaleItemPostDto> dto);
    }
}
