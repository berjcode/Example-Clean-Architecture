using MediatR;
using QuickSalesApp.Application.Messaging;

namespace QuickSalesApp.Application.Features.AppFeatures.AuthFeatures.Commands.Login
{
    public sealed record LoginCommand(
        string EmailAndUserName,
         string Password) : ICommand<LoginCommandResponse>;
}
