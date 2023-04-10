using Microsoft.EntityFrameworkCore;
using QuickSalesApp.Domain.Abstractions;

namespace QuickSalesApp.Domain.Repositories.GenericRepositories.AppDbContext;

public interface IAppRepository<T> where T : Entity
{
    void SetDbContextInstance(DbContext context);
    DbSet<T> Entity { get; set; }
}

