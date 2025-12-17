using Exercise_Razor.Helper;
using Exercise_Razor.Interface;
using Exercise_Razor.Models;
using Exercise_Razor.Repository;
using Exercise_Razor.Service;
using Microsoft.EntityFrameworkCore;

namespace Exercise_Razor.Extension
{
    public static class ApplicationServiceExtension
    {

        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            // Add Services
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();
            // Add AutoMapper



            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}
