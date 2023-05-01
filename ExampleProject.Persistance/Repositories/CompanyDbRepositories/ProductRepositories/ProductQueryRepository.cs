using QuickSalesApp.Domain.AppEntities;
using QuickSalesApp.Domain.Repositories.Company.ProductRepositories;
using QuickSalesApp.Persistance.Repositories.GenericRepositories.CompanyDbRepositories;

namespace QuickSalesApp.Persistance.Repositories.CompanyDbRepositories.ProductRepositories;

public sealed class ProductQueryRepository : CompanyDbQueryRepository<Product>, IProductQueryRepository
{
}

