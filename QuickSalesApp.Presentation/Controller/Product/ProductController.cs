using MediatR;
using Microsoft.AspNetCore.Mvc;
using QuickSalesApp.Application.Features.CompanyFeatures.ProductFeatures.Commands;
using QuickSalesApp.Presentation.Abstraction;


namespace QuickSalesApp.Presentation.Controller.Product
{
    public sealed class ProductController : ApiController
    {
        public ProductController(IMediator mediator) : base(mediator)
        {
        }



        [HttpPost("[action]")]

        public async Task<IActionResult> Create(CreateProductCommand request, CancellationToken cancellationToken)
        {
            CreateProductCommandResponse response = await _mediator.Send(request,cancellationToken);
            return Ok(response);
        }
    }
}
