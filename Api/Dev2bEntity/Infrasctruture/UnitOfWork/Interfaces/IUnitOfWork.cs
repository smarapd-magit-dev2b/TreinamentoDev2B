using System;
using System.Collections.Generic;
using System.Text;
using Infrasctruture.Repository.Interfaces;

namespace Infrasctruture.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IClienteRepository ClienteRepository { get; }
        IProdutoRepository ProdutoRepository { get; }
        IVendaRepository VendaRepository { get; }
        IItensVendaRepository ItensVendaRepository { get; }
        void Commit();
    }
}
