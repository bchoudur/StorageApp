using Microsoft.EntityFrameworkCore;
using StorageApp.Core.Interfaces.DataAccessHandlers;
using System;
using System.Collections.Generic;
using System.Text;
using StorageApp.DataAccessHandlers;
using StorageApp.DataAccessHandlers.Infrastructure;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class Configuration
    {
        public static IServiceCollection AddDataAccessHandlers(this IServiceCollection services, string connectionString) {
            services.AddScoped<StorageAppContext>();
            services.AddDbContext<StorageAppContext>(options => options.UseSqlServer(connectionString));

            services.AddTransient<IFileSampleHandler, FileSampleHandler>();
            return services;
        }
    }
}
