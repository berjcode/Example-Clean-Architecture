using QuickSalesApp.Domain.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Application.Features.AppFeatures.RoleFeatures.Queryies.GetAllRoles
{
   public sealed class GetAllRolesResponse
    {
        public IList<AppRole> Roles { get; set; }

    }
}
