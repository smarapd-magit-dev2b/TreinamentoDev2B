using System.Collections.Generic;
using Common.Dto;

namespace Service.ApplicationService.Interfaces
{
    public interface IVendaApplicationService
    {
        IEnumerable<VendaGetAllDto> GetAll();
        int Post(VendaPostDto venda);
    }
}
