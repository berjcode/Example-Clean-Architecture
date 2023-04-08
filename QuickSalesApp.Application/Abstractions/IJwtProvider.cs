using QuickSalesApp.Domain.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Application.Abstractions
{
  public interface IJwtProvider
    {
        Task<string> CreateTokenAsync (AppUser user, List<string> roles);
    }
}
