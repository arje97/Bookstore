using Core.Application.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace Core.Application
{
    public static  class ServiceExtensions
    {
        public static void AddAppLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<BookService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMvc().AddFluentValidation();


        }
    }
}
