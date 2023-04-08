using QuickSalesApp.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Domain.Repositories
{
    public interface IQueryRepository<T> : IRepository<T> where T : EntityBase
    {
        IQueryable<T> GetAll(bool isTracking= true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true);
        Task<T> GetById(int id, bool isTracking = true);
        Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression, bool isTracking = true);
        Task<T> GetFirst(bool isTracking = true);



    }
}
