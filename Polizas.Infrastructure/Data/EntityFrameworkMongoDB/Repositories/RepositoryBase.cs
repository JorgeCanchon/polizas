using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using Polizas.Core.Interfaces.Repositories;
using System.Linq.Expressions;

namespace Polizas.Infrastructure.Data.EntityFrameworkMongoDB.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
       private readonly IMongoCollection<T> _repositoryCollection;

        protected RepositoryBase(RepositoryContextMongoDB repositoryContext, string collectionName)
        {
            _repositoryCollection = repositoryContext.Context.GetCollection<T>(collectionName);
        }

        public async Task<List<T>> FindAll() =>
            await _repositoryCollection.Find(_ => true).ToListAsync();

        public async Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression) =>
            await _repositoryCollection.Find(expression).ToListAsync();

        public async Task Create(T entity) =>
            await _repositoryCollection.InsertOneAsync(entity);

        public async Task Update(Expression<Func<T, bool>> expression, T entity) =>
            await _repositoryCollection.ReplaceOneAsync<T>(expression, entity);

        public async Task Delete(Expression<Func<T, bool>> expression) =>
            await _repositoryCollection.DeleteOneAsync(expression);
    }
}
