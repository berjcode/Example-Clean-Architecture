using QuickSalesApp.Application.Messaging;
using QuickSalesApp.Application.Services.CompanyService;
using QuickSalesApp.Domain.AppEntities;

namespace QuickSalesApp.Application.Features.CompanyFeatures.ProductFeatures.Commands;

public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductCommandResponse>
{
    private readonly IProductService _productService;

    public CreateProductCommandHandler(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<CreateProductCommandResponse> Handle(CreateProductCommand request,
        CancellationToken cancellationToken)
    {
        Product product = await _productService.GetByCode(request.Code);
        if (product != null) throw new Exception("Bu Stok Daha Önce Tanımlanmıştır.");
        await _productService.CreateProductAsync(request, cancellationToken);
        return new();
    }
}

