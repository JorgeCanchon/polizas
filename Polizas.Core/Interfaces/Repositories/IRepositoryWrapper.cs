namespace Polizas.Core.Interfaces.Repositories
{
    public interface IRepositoryWrapper
    {
        IPolizaRepository Poliza { get; }
    }
}
