using Microsoft.AspNetCore.Identity;

namespace QuickSalesApp.Domain.AppEntities.Identity;

public sealed class AppUser : IdentityUser<string>
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public string RefreshToken { get; set; }
    public DateTime RefreshTokenExpires { get; set; }

}

