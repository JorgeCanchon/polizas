using Polizas.Core.Entities;
using Polizas.Core.Interfaces.Repositories;

namespace Polizas.Infrastructure.Data.EntityFrameworkMongoDB.Repositories
{
    public class PolizaRepository : RepositoryBase<Poliza>, IPolizaRepository
    {
        private readonly RepositoryContextMongoDB _repositoryContext;

        public PolizaRepository(RepositoryContextMongoDB repositoryContext)
            :base(repositoryContext, "Polizas")
        {
            
        }
    }
}
