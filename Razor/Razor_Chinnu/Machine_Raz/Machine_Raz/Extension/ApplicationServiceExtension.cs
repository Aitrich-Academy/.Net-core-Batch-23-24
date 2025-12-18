using Machine_Raz.Helper;
using Machine_Raz.Model;
using Microsoft.EntityFrameworkCore;

namespace Machine_Raz.Extension
{
    public static class ApplicationServiceExtension
    {

        public static IServiceCollection AddApplicationServices
         (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            // Add Services
            //services.AddScoped<IJobRepository, JobRepository>();
            //services.AddScoped<IJobService, JobService>();

            // Add AutoMapper
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}
