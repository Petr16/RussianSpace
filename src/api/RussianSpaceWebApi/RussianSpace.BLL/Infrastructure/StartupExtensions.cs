using AutoMapper;
using RussianSpace.BLL.Services;
using RussianSpace.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RussianSpace.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace RussianSpace.BLL.Infrastructure
{
    public static class StartupExtensions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
        }

        public static void AddRussianSpaceDBContext(this IServiceCollection services, string connectionString)
        {
            //services.AddDbContext<CustomerManagerDbContext>(options => options.UseNpgsql(connectionString));
            services.AddDbContext<RussianSpaceDBContext>();
        }

        public static void AddRussianSpaceBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<RequestService>();
            //services.AddScoped<CustomerService>();
            //services.AddScoped<StatusRequestService>();
        }
    }
}
