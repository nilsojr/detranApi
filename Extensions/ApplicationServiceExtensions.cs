using DetranApp.Data;
using DetranApp.Data.Impl;
using DetranApp.Data.Interfaces;
using DetranApp.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace DetranApp.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICondutorRepository, CondutorRepository>();

            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    configuration.GetConnectionString("DefaultConnection")));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("DetranAPI", new OpenApiInfo { Title = "API", Version = "v1"});
            });

            return services;   
        }
    }
}