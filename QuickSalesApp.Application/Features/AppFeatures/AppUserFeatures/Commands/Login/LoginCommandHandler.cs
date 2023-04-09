using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuickSalesApp.Application.Abstractions;
using QuickSalesApp.Application.Messaging;
using QuickSalesApp.Domain.AppEntities.Identity;

namespace QuickSalesApp.Application.Features.AppFeatures.AppUserFeatures.Commands.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;

        public LoginCommandHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser user = await _userManager.Users
                   .Where(p => p.Email == request.EmailAndUserName || p.UserName == request.EmailAndUserName)
                   .FirstOrDefaultAsync();

            if (user == null) throw new Exception("Kullanıcı Bulunamadı");

            var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);
            if (!checkUser) throw new Exception("Şifreniz Yanlış");

            List<string> roles = new();
            LoginCommandResponse response = new(
                user.Email,
                user.UserName,
                user.SurName,
                user.Id,
               await _jwtProvider.CreateTokenAsync(user, roles));

            return response;
        }
    }
}
