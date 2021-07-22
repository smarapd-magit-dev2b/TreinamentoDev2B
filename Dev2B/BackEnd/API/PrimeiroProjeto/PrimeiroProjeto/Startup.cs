using Infrastructure.Repository;
using Infrastructure.Repository.Context;
using Infrastructure.Repository.Interfaces;
using Infrastructure.UnitOfWork;
using Infrastructure.UnitOfWork.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Service.AplicationService;
using Service.AplicationService.Interfaces;

namespace PrimeiroProjeto
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IPersonAplicationService, PersonAplicationService>();
            services.AddScoped<IPersonUnitOfWork, PessoaUnitOfWork>();
            services.AddScoped<IPersonRepository, PersonRepository>();

            services.AddDbContext<PP_DbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Dev2bConnection")));

            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "Dev2B Api 1",
                    Version = "v1",
                    Description = "Api feita durante o treinamento Dev2B"
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
