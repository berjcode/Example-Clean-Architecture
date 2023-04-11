using MediatR;
using Microsoft.AspNetCore.Mvc;
using QuickSalesApp.Application.Features.AppFeatures.AppUserFeatures.Commands.Login;
using QuickSalesApp.Presentation.Abstraction;


namespace QuickSalesApp.Presentation.Controller.Auth
{
    public class AuthController : ApiController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginCommand request)
        {
            LoginCommandResponse response = await _mediator.Send(request);

            return Ok(response);
        }

    }
}
