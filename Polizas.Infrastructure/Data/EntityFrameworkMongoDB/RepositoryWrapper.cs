using Polizas.Core.Interfaces.Repositories;
using Polizas.Infrastructure.Data.EntityFrameworkMongoDB.Repositories;

namespace Polizas.Infrastructure.Data.EntityFrameworkMongoDB
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly RepositoryContextMongoDB _repositoryContextMongoDB;
        public IPolizaRepository? polizaRepository;

        public RepositoryWrapper(RepositoryContextMongoDB repositoryContextMongoDB)
        {
            _repositoryContextMongoDB = repositoryContextMongoDB ?? throw new ArgumentNullException(nameof(repositoryContextMongoDB));
        }

        public IPolizaRepository Poliza
        {
            get
            {
                if (polizaRepository == null)
                    return polizaRepository = new PolizaRepository(_repositoryContextMongoDB);
                return polizaRepository;
            }
        }

    }
}
