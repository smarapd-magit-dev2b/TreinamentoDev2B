using System;
using System.Collections.Generic;
using System.Text;
using Common.Dto;

namespace Service.ApplicationService.Interfaces
{
    public interface IClienteApplicationService
    {
        IEnumerable<ClienteGetAllDto> GetAll();
        ClienteGetAllDto GetById(int id);
        int Post(ClientePostDto cliente);
        void Put(int id, ClientePutDto cliente);
        void Delete(int id);
    }
}
