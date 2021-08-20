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
            _ = services.AddDbContext<TeacherLucasGODbContext>(options =>
                  options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            ConfigureBindingsAplicationService.RegisterBindings(services);
            ConfigureBindingsUnitOfWork.RegisterBindings(services);
            ConfigureBindingsRepository.RegisterBindings(services);
        }
    }
}
