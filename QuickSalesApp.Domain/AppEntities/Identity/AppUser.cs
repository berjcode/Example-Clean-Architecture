using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Domain.AppEntities.Identity
{
    public sealed class AppUser : IdentityUser<string>
    {

        public string Name { get; set; }
        public string SurName { get; set; }

        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpires { get; set; }


    }
}
