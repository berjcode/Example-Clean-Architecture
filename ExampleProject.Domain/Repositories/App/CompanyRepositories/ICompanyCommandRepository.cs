
using QuickSalesApp.Domain.Repositories.GenericRepositories.AppDbContext;

namespace QuickSalesApp.Domain.Repositories.App.CompanyRepositories;

public interface ICompanyCommandRepository : IAppCommandRepository<AppEntities.Company>
{
}
