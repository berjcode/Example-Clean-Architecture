using QuickSalesApp.Application.Services.AppServices;
using QuickSalesApp.Application.Services.CompanyService;
using QuickSalesApp.Domain;
using QuickSalesApp.Domain.Repositories.App.CompanyRepositories;
using QuickSalesApp.Domain.Repositories.App.MainRoleAndRoleRepositories;
using QuickSalesApp.Domain.Repositories.App.MainRoleAndUserRepositories;
using QuickSalesApp.Domain.Repositories.App.MainRoleRepositories;
using QuickSalesApp.Domain.Repositories.App.UserAndCompanyRepositories;
using QuickSalesApp.Domain.Repositories.Company.ProductRepositories;
using QuickSalesApp.Domain.UnitOfWork;
using QuickSalesApp.Persistance.Repositories.AppDbRepositories.CompanyRepositories;
using QuickSalesApp.Persistance.Repositories.AppDbRepositories.MainRoleAndRoleRepositories;
using QuickSalesApp.Persistance.Repositories.AppDbRepositories.MainRoleAndUserRepositories;
using QuickSalesApp.Persistance.Repositories.AppDbRepositories.MainRoleRepositories;
using QuickSalesApp.Persistance.Repositories.AppDbRepositories.UserAndCompanyRepositories;
using QuickSalesApp.Persistance.Repositories.CompanyDbRepositories.ProductRepositories;
using QuickSalesApp.Persistance.Services.AppServices;
using QuickSalesApp.Persistance.Services.CompanyServices;
using QuickSalesApp.Persistance.UnitOfWork;

namespace QuickSalesApp.WebApi.Configurations;

public class PersistanceDIServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {

        #region Context UnitOfWork ApplicationService
        services.AddScoped<ICompanyDbUnitOfWork, CompanyDbUnitOfWork>();
        services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();

        services.AddScoped<IContextService, QuickSalesApp.Persistance.ContextService>();

        #endregion

        #region Repository 

        //App
        //Company
        services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
        services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
        //MainRole
        services.AddScoped<IMainRoleCommadRepository, MainRoleCommandRepository>();
        services.AddScoped<IMainRoleQueryRepository, MainRoleQueryRepository>();
        services.AddScoped<IMainRoleAndRoleComandRepository, MainRoleAndRoleCommandRepository>();
        services.AddScoped<IMainRoleAndRoleQueryRepositories, MainRoleAndRoleQueryRepository>();
        services.AddScoped<IMainRoleAndUserCommandRepository, MainRoleAndUserCommandRepository>();
        services.AddScoped<IMainRoleAndUserQueryRepository, MainRoleAndUserQueryRepository>();
        //UserAndCompany
        services.AddScoped<IUserAndCompanyCommandRepository, UserAndCompanyCommandRepository>();
        services.AddScoped<IUserAndCompanyQueryRepository, UserAndCompanyQueryRepository>();


        #endregion

        #region CompanyDbContext
        services.AddScoped<IProductCommandRepository, ProductCommandRepository>();
        services.AddScoped<IProductQueryRepository, ProductQueryRepository>();

        #endregion


        #region ServicesApp
        //Auth
        services.AddScoped<IAuthService , AuthService>();
        services.AddScoped<ICompanyService, CompanyService>();
        //MainRole
        services.AddScoped<IMainRoleService, MainRoleService>();
        services.AddScoped<IMainRoleAndRoleRelationshipService, MainRoleAndRoleRelationshipService>();
        services.AddScoped<IMainRoleAndUserRelationshipService, MainRoleAndUserRelationshipService>();
        services.AddScoped<IUserAndCompanyRelationshipService, UserAndCompanyRelationshipService>();
        #endregion
        #region ServicesCompany


        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IRoleService, RoleService>();

        #endregion



    }
}
