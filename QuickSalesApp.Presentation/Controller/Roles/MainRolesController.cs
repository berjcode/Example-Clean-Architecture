

using MediatR;
using Microsoft.AspNetCore.Mvc;
using QuickSalesApp.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using QuickSalesApp.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateRole;
using QuickSalesApp.Presentation.Abstraction;

namespace QuickSalesApp.Presentation.Controller.Roles;

public sealed class MainRolesController : ApiController
{
    public MainRolesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateMainRole(CreateMainRoleCommand request)
    {
        CreateMainRoleResponse response = await _mediator.Send(request);
        return Ok(response);
    }

}
