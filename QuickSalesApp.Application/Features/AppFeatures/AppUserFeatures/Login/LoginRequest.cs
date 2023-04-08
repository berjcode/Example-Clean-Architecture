using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Application.Features.AppFeatures.AppUserFeatures.Login
{
   public sealed  class LoginRequest :IRequest<LoginResponse>
    {

        public string EmailAndUserName { get; set; }
      
        public string Password { get; set; }
      
      

    }
}
