using MediatR;
using Microsoft.AspNetCore.Mvc;
using QuickSalesApp.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using QuickSalesApp.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase;
using QuickSalesApp.Presentation.Abstraction;

namespace QuickSalesApp.Presentation.Controller.Companies
{
    public class CompaniesController : ApiController
    {
        public CompaniesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]

        public async Task<IActionResult> CreateCompany(CreateCompanyRequest request)
        {
            CreateCompanyResponse response = await _mediator.Send(request);
            return Ok(response);

        }



        [HttpGet("[action]")]

        public async Task<IActionResult> MigrateCompanyDatabase()
        {
            MigrateCompanyDatabaseRequest request = new();
            MigrateCompanyDatabaseResponse response = await _mediator.Send(request);
            return Ok(response);
        }

    }
}
