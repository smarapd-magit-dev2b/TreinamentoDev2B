using Domain;
using Infrastructure.Repository;
using Infrastructure.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Service.DependencyInjection
{
    public class ConfigureBindingsRepository
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            _ = services.AddScoped<IRepository<User>, Repository<User>>();
            _ = services.AddScoped<IRepository<Teacher>, Repository<Teacher>>();
            _ = services.AddScoped<IRepository<Address>, Repository<Address>>();
            _ = services.AddScoped<IRepository<Discipline>, Repository<Discipline>>();
        }
    }
}
