using Core.Application.Interfaces.Repositories;
using Infrastructure.Database.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Database
{
   public static class ServiceExtensions
    {
        public static void AddDbLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookstoreDbContext>(x => x.UseSqlServer(configuration.GetConnectionString("BookstoreDbConnection")));
            services.AddScoped<IBookRepository, BookRepository>();

        }
    }
}
