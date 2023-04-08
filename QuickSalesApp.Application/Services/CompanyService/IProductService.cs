using QuickSalesApp.Application.Features.CompanyFeatures.ProductFeatures.Commands;

namespace QuickSalesApp.Application.Services.CompanyService
{
   public  interface IProductService
    {
        Task CreateProductAsync(CreateProductRequest request);

    }
}
