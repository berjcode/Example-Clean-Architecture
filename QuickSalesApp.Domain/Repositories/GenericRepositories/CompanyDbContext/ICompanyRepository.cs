using Microsoft.EntityFrameworkCore;
using QuickSalesApp.Domain.Abstractions;
namespace QuickSalesApp.Domain.Repositories.GenericRepositories.CompanyDbContext;

public interface ICompanyRepository<T> where T : EntityBase
{
    void SetDbContextInstance(DbContext context);
    DbSet<T> Entity { get; set; }
}

