using Microsoft.EntityFrameworkCore;
using QuickSalesApp.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Domain.Repositories
{
   public interface IRepository<T> where T : EntityBase
    {
        void SetDbContextInstance(DbContext context);
        DbSet<T> Entity { get; set; }
    }
}
