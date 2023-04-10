using QuickSalesApp.Application.Services.AppServices;
using QuickSalesApp.Application.Services.CompanyService;
using QuickSalesApp.Domain.UnitOfWork;
using QuickSalesApp.Domain;
using QuickSalesApp.Persistance.Services.AppServices;
using QuickSalesApp.Persistance.Services.CompanyServices;
using QuickSalesApp.Persistance.UnitOfWork;
using QuickSalesApp.Domain.Repositories.Company.ProductRepositories;
using QuickSalesApp.Persistance.Repositories.CompanyDbRepositories.ProductRepositories;
using QuickSalesApp.Domain.Repositories.App.CompanyRepositories;
using QuickSalesApp.Persistance.Repositories.AppDbRepositories.CompanyRepositories;

namespace QuickSalesApp.WebApi.Configurations
{
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
            services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
            services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
            #endregion

            #region CompanyDbContext
            services.AddScoped<IProductCommandRepository, ProductCommandRepository>();
            services.AddScoped<IProductQueryRepository, ProductQueryRepository>();

            #endregion


            #region ServicesApp
            services.AddScoped<ICompanyService, CompanyService>();
            #endregion
            #region ServicesCompany


            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IRoleService , RoleService>();    

            #endregion

            

        }
    }
}
