
using MediatR;
using QuickSalesApp.Presentation.Abstraction;

namespace QuickSalesApp.Presentation.Controller.User;

public sealed class UserAndCompanyRelationshipController : ApiController
{
    public UserAndCompanyRelationshipController(IMediator mediator) : base(mediator)
    {
    }


}
