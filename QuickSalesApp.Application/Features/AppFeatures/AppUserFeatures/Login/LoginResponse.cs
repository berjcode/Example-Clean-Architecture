using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public class LoginResponse
    {
        public string Token { get; set; }

        public string Email { get; set; }

        public string  UserId { get; set; }
        public string  Name { get; set; }
        public string Surname { get; set; }
    }
}
