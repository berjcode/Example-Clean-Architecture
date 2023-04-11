
using MediatR;
using QuickSalesApp.Domain.AppEntities;

namespace QuickSalesApp.Application.Services.AppServices;

public  interface IMainRoleService
{
   Task<MainRole>  GetByTitleAndCompanyId(string title, string companyId);
    Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken);

}
