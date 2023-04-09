using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuickSalesApp.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using QuickSalesApp.Application.Services.AppServices;
using QuickSalesApp.Domain.AppEntities;
using QuickSalesApp.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Persistance.Services.AppServices
{
    public sealed class CompanyService : ICompanyService
    {
        private static readonly Func<AppDbContext, string, Task<Company?>> GetCompanyByNameCompiled = EF.CompileAsyncQuery((AppDbContext context, string name)
            => context.Set<Company>().FirstOrDefault(p => p.Name== name));
                          

      
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CompanyService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateCompany(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            Company company = _mapper.Map<Company>(request);
            company.Id = Guid.NewGuid().ToString();
            company.UpdateDate = null;
            company.CreatedDate = DateTime.Now;

            await _context.Set<Company>().AddAsync(company,cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<Company?> GetCompanyByName(string name)
        {
            return await GetCompanyByNameCompiled(_context,name);
        }

        public async Task MigrateCompanyDatabases()
        {
          var compaines = await _context.Set<Company>().ToListAsync();

            foreach (var company in compaines)
            {
                var db =new CompanyDbContext(company);
                db.Database.Migrate();  
            }   
        }
    }
}
