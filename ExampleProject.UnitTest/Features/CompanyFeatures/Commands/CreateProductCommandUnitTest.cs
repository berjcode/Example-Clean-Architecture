using Moq;
using QuickSalesApp.Application.Features.CompanyFeatures.ProductFeatures.Commands;
using QuickSalesApp.Application.Services.CompanyService;
using QuickSalesApp.Domain.AppEntities;
using Shouldly;

namespace QuickSalesApp.UnitTest.Features.CompanyFeatures.Commands;

public class CreateProductCommandUnitTest
{
    private readonly Mock<IProductService> _productService;
    public CreateProductCommandUnitTest()
    {
        _productService = new();
    }

    [Fact]
    public async Task ProductShouldBeNull()
    {
        Product product = await _productService.Object.GetByCode("22");
        product.ShouldBeNull();
    }


    [Fact]
    public async Task CreateProductResponseShouldNotBeNull()
    {
        var command = new CreateProductCommand(
            Code: "STK001",
            Name: "Peçete",
            Photo: "null",
            CategoryId: 2,
            CompanyId: "23232");

        var handler = new CreateProductCommandHandler(_productService.Object);
        CreateProductCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();

    }
}

