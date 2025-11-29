using Microsoft.EntityFrameworkCore;
using MVC_HireMeNow_Workshop.Data;
using MVC_HireMeNow_Workshop.Interfaces;
using MVC_HireMeNow_Workshop.Repositories;
using MVC_HireMeNow_Workshop.Services;
using System.Reflection.Metadata.Ecma335;

namespace MVC_HireMeNow_Workshop.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped<IPublicService, PublicService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IJobRepository, JobRepository>();



            return services;
        }

        
    }
}
