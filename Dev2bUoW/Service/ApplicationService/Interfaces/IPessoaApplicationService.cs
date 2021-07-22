using Common.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.ApplicationService.Interfaces
{
    public interface IPessoaApplicationService
    {
        int Post(PessoaPostDto pessoa);
        IEnumerable<PessoaGetAllDto> GetAll();
    }
}
