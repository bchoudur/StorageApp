using StorageApp.Managers;
using StorageApp.Core.Interfaces.Managers;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class Configuration
    {
        public static IServiceCollection AddManagers(this IServiceCollection services)
        {
            services.AddTransient<IFileSampleManager, FileSampleManager>();
            
            return services;
        }
    }
}
