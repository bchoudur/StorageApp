using System;
using System.Collections.Generic;
using System.Text;
using StorageApp.Core.Interfaces.Engines;
using StorageApp.Engines;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class Configuration
    {
        public static IServiceCollection AddEngines(this IServiceCollection services)
        {
            services.AddTransient<IFileSampleEngine, FileSampleEngine>();

            return services;
        }
    }
}
