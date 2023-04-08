using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Domain.AppEntities.Identity
{
    public sealed class AppRole:IdentityRole<string>
    {
        public string Code { get; set; }
    }
}
