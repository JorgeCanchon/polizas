using Autofac;
using Polizas.Core.Interfaces.Repositories;
using Polizas.Infrastructure.Data.EntityFrameworkMongoDB;

namespace Polizas.Infrastructure
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RepositoryWrapper>().As<IRepositoryWrapper>().InstancePerLifetimeScope();
        }
    }
}
