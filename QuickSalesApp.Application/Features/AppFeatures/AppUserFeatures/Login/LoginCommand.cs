using MediatR;
using QuickSalesApp.Application.Messaging;

namespace QuickSalesApp.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed record LoginCommand(
        string EmailAndUserName,
         string Password) : ICommand<LoginCommandResponse>;
}
