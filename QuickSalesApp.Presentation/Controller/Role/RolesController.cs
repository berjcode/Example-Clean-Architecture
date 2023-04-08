using MediatR;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<IActionResult> CreateRole(CreateRoleRequest request)
        {
            CreateRoleResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllRoles()
        {
            GetAllRolesRequest request = new GetAllRolesRequest();
            GetAllRolesResponse response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> UpdateRole(UpdateRoleRequest request)
        {
            UpdateRoleResponse response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpGet("[action]/{id}")]

        public async Task<IActionResult> DeleteRole(string id)
        {
            DeleteRoleRequest request = new()
            {
                Id = id
            };
            DeleteRoleResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
