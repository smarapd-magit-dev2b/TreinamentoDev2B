using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.DependencyInjection.ApplicationService;
using Service.DependencyInjection.Repository;
using Service.DependencyInjection.Unitofwork;

namespace Service.DependencyInjection
{
    public class ConfigureBindingsDependencyInjection
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureBindingsClienteRepository.RegisterBindings(services, configuration);
            ConfigureBindingsProdutoRepository.RegisterBindings(services, configuration);
            ConfigureBindingsVendaRepository.RegisterBindings(services, configuration);
            ConfigureBindingsItensVendaRepository.RegisterBindings(services, configuration);
            ConfigureBindingsClienteApplicationService.RegisterBindings(services, configuration);
            ConfigureBindingsProdutoApplicationService.RegisterBindings(services, configuration);
            ConfigureBindingsVendaApplicationService.RegisterBindings(services, configuration);
            ConfigureBindingsUnitOfWork.RegisterBindings(services, configuration);
            ConfigureBindingsDatabaseContext.RegisterBindings(services, configuration);
        }
    }
}
