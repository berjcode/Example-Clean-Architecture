using MediatR;
using QuickSalesApp.Presentation.Abstraction;

namespace QuickSalesApp.Presentation.Controller.Roles;

public sealed class MainRoleAndRoleRelationshipController : ApiController
{
    public MainRoleAndRoleRelationshipController(IMediator mediator) : base(mediator)
    {
    }
}
