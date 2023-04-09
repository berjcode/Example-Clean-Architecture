﻿using Microsoft.EntityFrameworkCore;
using QuickSalesApp.Domain.Abstractions;
using QuickSalesApp.Domain.Repositories;
using QuickSalesApp.Persistance.Context;

namespace QuickSalesApp.Persistance.Repositories
{
    public class CommanRepository<T> : ICommandRepository<T> where T : EntityBase
    {
        private static readonly Func<CompanyDbContext,int ,Task<T>> GetByIdCompiled=
            EF.CompileAsyncQuery((CompanyDbContext context,int id) => 
            context.Set<T>().FirstOrDefault(p =>p.Id == id));

        private CompanyDbContext _context;

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext context)
        {
            _context = (CompanyDbContext)context;
            Entity = _context.Set<T>();
        }

        public async Task AddAsync(T entity, CancellationToken cancellationToken)
        {
            await Entity.AddAsync(entity,cancellationToken);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken)
        {
            await Entity.AddRangeAsync(entities,cancellationToken);
        }

        public void Remove(T entity)
        {
            Entity.Remove(entity);
        }

        public async Task RemoveById(int id)
        {
             T entity = await GetByIdCompiled(_context, id);
            Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Entity.RemoveRange(entities);

        }

        public void Update(T entity)
        {
            Entity.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
           Entity.UpdateRange(entities);
        }
    }
}
