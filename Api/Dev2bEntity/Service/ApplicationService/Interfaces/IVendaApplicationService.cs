using System;
using System.Collections.Generic;
using System.Text;
using Common.Dto;

namespace Service.ApplicationService.Interfaces
{
    public interface IVendaApplicationService
    {
        IEnumerable<VendaGetAllDto> GetAll();
        VendaGetAllDto GetById(int id);
        int Post(VendaPostDto venda);
    }
}
