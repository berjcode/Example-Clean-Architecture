using QuickSalesApp.Domain.AppEntities;
using QuickSalesApp.Domain.Repositories.ProductRepositories;

namespace QuickSalesApp.Persistance.Repositories.GenericRepositories.CompanyDbRepositories.ProductRepositories;

public sealed class ProductCommandRepository : CompanyCommandRepository<Product>, IProductCommandRepository
{
}

