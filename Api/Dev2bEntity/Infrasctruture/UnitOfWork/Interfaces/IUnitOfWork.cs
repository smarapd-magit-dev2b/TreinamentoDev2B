﻿using Infrasctruture.Repository.Interfaces;

namespace Infrasctruture.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IClienteRepository ClienteRepository { get; }
        IProdutoRepository ProdutoRepository { get; }
        IVendaRepository VendaRepository { get; }
        void Commit();
    }
}
