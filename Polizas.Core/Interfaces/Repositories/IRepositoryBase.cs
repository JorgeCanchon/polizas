using System.Linq.Expressions;

namespace Polizas.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<T>
    {
        Task<List<T>> FindAll();
        Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression);
        Task Create(T entity);
        Task Update(Expression<Func<T, bool>> expression, T entity);
        Task Delete(Expression<Func<T, bool>> expression);
    }
}
