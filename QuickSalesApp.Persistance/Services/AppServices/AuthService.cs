
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuickSalesApp.Application.Services.AppServices;
using QuickSalesApp.Domain.AppEntities;
using QuickSalesApp.Domain.AppEntities.Identity;

namespace QuickSalesApp.Persistance.Services.AppServices;

public class AuthService : IAuthService
{

    private readonly UserManager<AppUser> _userManager;
    private readonly IUserAndCompanyRelationshipService _userAndCompanyRelationshipService;

    public AuthService(UserManager<AppUser> userManager, IUserAndCompanyRelationshipService userAndCompanyRelationshipService)
    {
        _userManager = userManager;
        _userAndCompanyRelationshipService = userAndCompanyRelationshipService;
    }

    public async Task<bool> CheckPasswordAsync(AppUser user , string password)
    {
      return   await _userManager.CheckPasswordAsync(user, password);
    }

    public async Task<AppUser> GetByEmailOrUserNameAsync(string emailOrUserName)
    {
        return await _userManager.Users.Where(p => p.Email == emailOrUserName || p.UserName == emailOrUserName).FirstOrDefaultAsync();

    }

    public async Task<IList<UserAndCompanyRelationship>> GetCompanyListByUserIdAsync(string userId)
    {
        return await _userAndCompanyRelationshipService.GetListByUserId(userId);
    }
}
