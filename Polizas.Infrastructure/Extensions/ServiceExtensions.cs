using Microsoft.Extensions.DependencyInjection;
using Polizas.Core.Interfaces.Repositories;
using Polizas.Infrastructure.Data.EntityFrameworkMongoDB;

namespace Polizas.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection service)
        {
            service.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

        public static void ConfigureMyMongoDBContext(this IServiceCollection services)
        {
            services.AddSingleton<RepositoryContextMongoDB>();
        }
    }
}
