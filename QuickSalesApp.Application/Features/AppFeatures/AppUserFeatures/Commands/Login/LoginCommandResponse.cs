using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickSalesApp.Application.Features.AppFeatures.AppUserFeatures.Commands.Login
{
    public sealed record LoginCommandResponse(

        string Email,


        string Name,
        string SurName,
    string UserId,
         string Token);
}
