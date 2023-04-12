using MediatR;
using QuickSalesApp.Presentation.Abstraction;

namespace QuickSalesApp.Presentation.Controller.Roles;

public sealed class MainRoleAndUserRelationshipController : ApiController
{
    public MainRoleAndUserRelationshipController(IMediator mediator) : base(mediator)
    {
    }
}
