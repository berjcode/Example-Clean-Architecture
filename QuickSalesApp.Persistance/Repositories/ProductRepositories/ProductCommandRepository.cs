using QuickSalesApp.Domain.AppEntities;
using QuickSalesApp.Domain.Repositories.ProductRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Persistance.Repositories.ProductRepositories
{
    public sealed class ProductCommandRepository : CommanRepository<Product>,IProductCommandRepository
    {
    }
}
