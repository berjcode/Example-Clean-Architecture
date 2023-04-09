using System;
using System.Collections.Generic;
using System.Linq;
namespace QuickSalesApp.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed record LoginCommandResponse(
        string Token,
        string Email,
        string UserId,
        string Name,
        string SurName);
}
