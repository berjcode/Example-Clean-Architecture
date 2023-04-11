
using QuickSalesApp.Application.Services.AppServices;
using QuickSalesApp.Domain;
using QuickSalesApp.Domain.AppEntities;
using QuickSalesApp.Domain.Repositories.App.MainRoleRepositories;

namespace QuickSalesApp.Persistance.Services.AppServices;

public class MainRoleService : IMainRoleService
{

    private readonly IMainRoleCommadRepository _mainRoleCommadRepository;
    private readonly IMainRoleQueryRepository _mainRoleQueryRepository;
    private IAppUnitOfWork _appUnitOfWork;

    public MainRoleService(IMainRoleCommadRepository mainRoleCommadRepository, IMainRoleQueryRepository mainRoleQueryRepository, IAppUnitOfWork appUnitOfWork)
    {
        _mainRoleCommadRepository = mainRoleCommadRepository;
        _mainRoleQueryRepository = mainRoleQueryRepository;
        _appUnitOfWork = appUnitOfWork;
    }

    public async Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken)
    {
        await _mainRoleCommadRepository.AddAsync(mainRole,cancellationToken);
        await _appUnitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task<MainRole> GetByTitleAndCompanyId(string title, string companyId)
    {
       //if(companyId == null) return await _mainRoleQueryRepository.GetFirstByExpression(p => p.Title == title);

       return await _mainRoleQueryRepository.GetFirstByExpression(p =>p.Title == title && p.CompanyId == companyId,false);
    }
}
