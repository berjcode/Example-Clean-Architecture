using MediatR;
using Microsoft.AspNetCore.Mvc;
using QuickSalesApp.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRole;
using QuickSalesApp.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using QuickSalesApp.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
using QuickSalesApp.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
using QuickSalesApp.Application.Features.AppFeatures.RoleFeatures.Queryies.GetAllRoles;
using QuickSalesApp.Presentation.Abstraction;

namespace QuickSalesApp.Presentation.Controller.Role
{
    public sealed class RolesController : ApiController
    {
        public RolesController(IMediator mediator) : base(mediator)
        {
        }



        [HttpPost("[action]")]

        public async Task<IActionResult> CreateRole(CreateRoleCommand request)
        {
            CreateRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllRoles()
        {
            GetAllRolesQuery request = new GetAllRolesQuery();
            GetAllRolesQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateRole(UpdateRoleCommand request)
        {
            UpdateRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpGet("[action]/{id}")]

        public async Task<IActionResult> DeleteRole(string id)
        {
            DeleteRoleCommand request = new(id);

            DeleteRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> CreateAllRoles()
        {
            CreateAllRolesCommand request = new();
            CreateAllRolesCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
