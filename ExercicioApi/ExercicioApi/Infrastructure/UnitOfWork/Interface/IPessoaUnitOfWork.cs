using Infrastructure.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.UnitOfWork.Interface
{
    public interface IPessoaUnitOfWork
    {
        IPessoaRepository PessoaRepository { get; }
    }
}
