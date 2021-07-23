using System;
using System.Collections.Generic;
using System.Text;
using Common.Dto;

namespace Service.ApplicationService.Interfaces
{
    public interface IVendaApplicationService
    {
        int Post(VendaPostDto venda);
    }
}
