using ManagerDiet.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DietDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ManagerDietDatabase")));
            services.AddScoped<IDietDbContext, DietDbContext>();

            return services;
        }
    }
}
