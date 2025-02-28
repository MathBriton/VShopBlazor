using ApiMangas.Entities;
using System.Collections;
using System.Linq.Expressions;

namespace ApiMangas.Repositories.Interfaces;

public interface IRepository<T> : IDisposable where T : Entity
{
    Task AddAsync(T entity);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync (int? id);
    Task UpdateAsync (T entity);
    Task RemoveAsync (int? id);

    Task<IEnumerable>>
    SearchAsync(Expression<Func<T, bool>> predicate);
}