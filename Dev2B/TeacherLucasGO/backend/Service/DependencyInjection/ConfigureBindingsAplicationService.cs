using Microsoft.Extensions.DependencyInjection;
using Service.AplicationService;
using Service.AplicationService.Interfaces;

namespace Service.DependencyInjection
{
    public class ConfigureBindingsAplicationService
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            _ = services.AddScoped<IUserAplicationService, UserAplicationService>();
            _ = services.AddScoped<ITeacherAplicationService, TeacherAplicationService>();

        }
    }
}
