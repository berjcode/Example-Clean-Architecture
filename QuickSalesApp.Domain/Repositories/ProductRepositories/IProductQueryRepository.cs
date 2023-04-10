using QuickSalesApp.Domain.AppEntities;
using QuickSalesApp.Domain.Repositories.GenericRepositories.CompanyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Domain.Repositories.ProductRepositories
{
    public interface IProductQueryRepository : ICompanyQueryRepository<Product>
    {
    }
}
