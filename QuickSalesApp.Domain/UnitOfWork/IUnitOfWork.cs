using Microsoft.EntityFrameworkCore;
namespace QuickSalesApp.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        void SetDbContextInstance(DbContext context);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
