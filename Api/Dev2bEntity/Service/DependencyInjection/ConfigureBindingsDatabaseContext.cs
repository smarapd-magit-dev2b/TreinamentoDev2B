using Infrasctruture.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Service.DependencyInjection
{
    public class ConfigureBindingsDatabaseContext
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Dev2bEntityDbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("Dev2bConnection")));
        }
    }
}
