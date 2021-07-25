using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.ApplicationService;
using Service.ApplicationService.Interfaces;

namespace Service.DependencyInjection.ApplicationService
{
    public class ConfigureBindingsProdutoApplicationService
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProdutoApplicationService, ProdutoApplicationService>();
        }
    }
}
