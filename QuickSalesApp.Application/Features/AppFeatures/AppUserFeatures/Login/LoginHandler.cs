using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuickSalesApp.Application.Abstractions;
using QuickSalesApp.Domain.AppEntities.Identity;

namespace QuickSalesApp.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;

        public LoginHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
        }

        public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
         AppUser user =   await _userManager.Users
                .Where(p => p.Email == request.EmailAndUserName || p.UserName== request.EmailAndUserName)
                .FirstOrDefaultAsync();

            if (user == null) throw new Exception("Kullanıcı Bulunamadı");

            var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);
            if (!checkUser) throw new Exception("Şifreniz Yanlış");

            List<string> roles = new();
            LoginResponse response = new()
            {
                Email = user.Email,
                Name = user.UserName,
                Surname = user.UserName,
                UserId = user.Id,
                Token = await _jwtProvider.CreateTokenAsync(user, roles)
            };

            return response;
           
        }
    }
}
