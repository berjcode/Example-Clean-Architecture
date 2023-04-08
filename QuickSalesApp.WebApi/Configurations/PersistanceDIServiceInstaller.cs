using QuickSalesApp.Application.Services.AppServices;
using QuickSalesApp.Application.Services.CompanyService;
using QuickSalesApp.Domain.Repositories.ProductRepositories;
using QuickSalesApp.Domain.UnitOfWork;
using QuickSalesApp.Domain;
using QuickSalesApp.Persistance.Repositories.ProductRepositories;
using QuickSalesApp.Persistance.Services.AppServices;
using QuickSalesApp.Persistance.Services.CompanyServices;
using QuickSalesApp.Persistance.UnitOfWork;

namespace QuickSalesApp.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {

            #region Context UnitOfWork ApplicationService
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IContextService, QuickSalesApp.Persistance.ContextService>();
          
            #endregion

            #region Repository 
            services.AddScoped<IProductCommandRepository, ProductCommandRepository>();
            services.AddScoped<IProductQueryRepository, ProductQueryRepository>();
            #endregion

            #region Services
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IRoleService , RoleService>();    
            #endregion

        }
    }
}
