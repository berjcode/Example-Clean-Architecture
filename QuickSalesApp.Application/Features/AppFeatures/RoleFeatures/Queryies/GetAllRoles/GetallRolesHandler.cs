using MediatR;
using QuickSalesApp.Application.Services.AppServices;
using QuickSalesApp.Domain.AppEntities.Identity;


namespace QuickSalesApp.Application.Features.AppFeatures.RoleFeatures.Queryies.GetAllRoles
{
    public sealed class GetallRolesHandler : IRequestHandler<GetAllRolesRequest, GetAllRolesResponse>
    {
        private readonly IRoleService _roleService;

        public GetallRolesHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<GetAllRolesResponse> Handle(GetAllRolesRequest request, CancellationToken cancellationToken)
        {
            IList<AppRole> roles = await _roleService.GetAllRolesAync();
            return new GetAllRolesResponse { Roles = roles };

        }
    }
}
