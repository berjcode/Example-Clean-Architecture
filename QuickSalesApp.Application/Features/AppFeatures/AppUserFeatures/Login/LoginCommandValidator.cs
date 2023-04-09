using FluentValidation;

namespace QuickSalesApp.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(p => p.EmailAndUserName).NotEmpty()
                .WithMessage("Mail veya Kullanıcı Adı Girmelisiniz");
            RuleFor(p => p.Password).NotEmpty()
                .WithMessage("Şifre Boş Olamaz");
        }
    }
}
