using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Infrasctruture.Repository.Interfaces
{
    public interface IItensVendaRepository
    {
        void Post(ItensVenda itensVenda);

    }
}
