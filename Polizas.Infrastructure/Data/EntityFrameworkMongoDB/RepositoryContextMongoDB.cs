using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Polizas.Core.Entities;

namespace Polizas.Infrastructure.Data.EntityFrameworkMongoDB
{
    public class RepositoryContextMongoDB
    {
        public virtual IMongoDatabase Context { get; set; }

        public RepositoryContextMongoDB(IOptions<PolizaStoreDatabaseSettings> polizaStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(polizaStoreDatabaseSettings.Value.ConnectionString);
            Context = mongoClient.GetDatabase(polizaStoreDatabaseSettings.Value.DatabaseName);
        }
    }
}
