using QuickSalesApp.Application.Messaging;

namespace QuickSalesApp.Application.Features.CompanyFeatures.ProductFeatures.Commands
{
    public sealed record CreateProductCommand(
        string Code,
        string Name,
        string Photo,
        int CategoryId,
        string CompanyId
        ) : ICommand<CreateProductCommandResponse>;

}
