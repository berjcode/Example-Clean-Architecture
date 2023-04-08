using QuickSalesApp.Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Domain.Repositories.ProductRepositories
{
    public interface IProductQueryRepository: IQueryRepository<Product>
    {
    }
}
