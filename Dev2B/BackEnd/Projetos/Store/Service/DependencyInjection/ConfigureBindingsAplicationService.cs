using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.AplicationService;
using Service.AplicationService.Interfaces;

namespace Service.DependencyInjection
{
    public class ConfigureBindingsAplicationService
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICustomerAplicationService, CustomerAplicationService>();
            services.AddScoped<IProductAplicationService, ProductAplicationService>();
            services.AddScoped<ISaleAplicationService, SaleAplicationService>();
        }
    }
}
