using Autofac;
using Polizas.Core.Interfaces.UsesCases;
using Polizas.Core.UsesCases;

namespace Polizas.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PolizaInteractor>().As<IPolizaInteractor>().InstancePerLifetimeScope();
        }
    }
}
