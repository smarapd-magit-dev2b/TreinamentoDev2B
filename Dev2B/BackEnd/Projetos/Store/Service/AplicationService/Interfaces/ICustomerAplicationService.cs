using Commom.Dto.Customer;
using System.Collections.Generic;

namespace Service.AplicationService.Interfaces
{
    public interface ICustomerAplicationService
    {
        IEnumerable<CustomerGetDto> Get();
        CustomerGetDto Get(int id);
        int Post(CustomerPostDto dto);
        void Put(int id, CustomerPostDto dto);
        void Delete(int id);
    }
}
