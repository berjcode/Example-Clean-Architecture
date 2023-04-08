using MediatR;


namespace QuickSalesApp.Application.Features.CompanyFeatures.ProductFeatures.Commands
{
 public sealed class CreateProductRequest :IRequest<CreateProductResponse>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Photo { get; set; }

        
        public int CategoryId { get; set; }
        public string  Tentant { get; set; }

    }
}
