using Infrastructure.Repository.Interface;



namespace Infrastructure.UnitOfWork.Interface
{
    public interface IPessoaUnitOfWork 
    {
        public IPessoaRepository PessoaRepository { get; }
    
    }
}
