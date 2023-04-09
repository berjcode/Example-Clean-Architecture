using FluentValidation;
using MediatR;
using QuickSalesApp.Application.Behavior;

namespace QuickSalesApp.WebApi.Configurations
{
    public class ApplicationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(QuickSalesApp.Application.AssemblyReference)));

            services.AddTransient(typeof(IPipelineBehavior<,>),(
                typeof(ValidationBehavior<,>)));

            services.AddValidatorsFromAssembly(typeof(QuickSalesApp.Application.AssemblyReference).Assembly);
        }
    }
}
