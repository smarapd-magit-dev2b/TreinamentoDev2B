using Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Service.DependencyInjection
{
    public class ConfigureBindings
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StoreDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Dev2bConnection")));

            ConfigureBindingsAplicationService.RegisterBindings(services, configuration);
            ConfigureBindingsRepository.RegisterBindings(services, configuration);
            ConfigureBindingsUnitOfWork.RegisterBindings(services, configuration);
        }
    }
}
