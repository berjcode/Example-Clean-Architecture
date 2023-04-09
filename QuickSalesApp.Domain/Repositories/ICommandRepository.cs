using QuickSalesApp.Domain.Abstractions;

namespace QuickSalesApp.Domain.Repositories
{
    public interface ICommandRepository<T> : IRepository<T> where T : EntityBase
    {

        Task AddAsync(T entity, CancellationToken cancellationToken);
        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        Task RemoveById(int id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
