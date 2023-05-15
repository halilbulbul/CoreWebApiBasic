using CoreWebApi.Infrastructure.DataAccess.Abstract;
using CoreWebApi.Infrastructure.Model.Abstract;
using CoreWebApi.Infrastructure.Model.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.Infrastructure.DataAccess.Concrete.EntityFramework
{
    public class BaseRepositoryEf<TEntity, TContext> : IEntityRepository<TEntity>
            where TEntity : class, IEntity, new()
            where TContext : DbContext, IDisposable, new()
    {
        public bool Add(TEntity entity)
        {
            using (TContext ctx = new())
            {
                ctx.Set<TEntity>().Add(entity);
                return ctx.SaveChanges() > 0;
            }
        }

        public bool Delete(TEntity entity)
        {
            using (TContext ctx = new())
            {
                ctx.Set<TEntity>().Remove(entity);
                return ctx.SaveChanges() > 0;
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includeList)
        {
            using (TContext ctx = new())
            {
                IQueryable<TEntity> _dbSet = ctx.Set<TEntity>();

                if (includeList != null)
                {
                    foreach (var item in includeList)
                    {
                        _dbSet = _dbSet.Include(item);
                    }
                }
                return _dbSet.SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(RepositoryParameters<TEntity> parameters = null)
        {
            using (TContext ctx = new())
            {
                IQueryable<TEntity> _dbSet = ctx.Set<TEntity>();

                if (parameters != null)
                {
                    if (parameters.filter != null)
                        _dbSet = _dbSet.Where(parameters.filter);

                    if (parameters.includeList != null)
                    {
                        foreach (var item in parameters.includeList)
                        {
                            _dbSet = _dbSet.Include(item);
                        }
                    }

                    if (parameters.skip != 0)
                        _dbSet = _dbSet.Skip(parameters.skip);

                    if (parameters.take != 0)
                        _dbSet = _dbSet.Take(parameters.take);

                    if (parameters.sortDirection != null)
                    {
                        switch (parameters.sortDirection)
                        {
                            case SortDirection.Ascending:
                                _dbSet = _dbSet.OrderBy(parameters.orderBy);
                                break;
                            case SortDirection.Descending:
                                _dbSet = _dbSet.OrderByDescending(parameters.orderBy);
                                break;
                            default:
                                break;
                        }
                    }

                }

                return _dbSet.ToList();
            }
        }

        public bool Update(TEntity entity)
        {
            using (TContext ctx = new())
            {
                ctx.Set<TEntity>().Update(entity);
                return ctx.SaveChanges() > 0;
            }
        }
    }
}
