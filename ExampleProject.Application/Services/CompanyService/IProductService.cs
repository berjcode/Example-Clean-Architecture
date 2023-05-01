using QuickSalesApp.Application.Features.CompanyFeatures.ProductFeatures.Commands;
using QuickSalesApp.Domain.AppEntities;

namespace QuickSalesApp.Application.Services.CompanyService
{
   public  interface IProductService
    {
        Task CreateProductAsync(CreateProductCommand request, CancellationToken cancellationToken);
        Task<Product> GetByCode( string code); 

    }
}
