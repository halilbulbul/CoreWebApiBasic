using CoreWebApi.Infrastructure.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.Infrastructure.DataAccess.Abstract
{
    public interface IEntityRepository<TEntity>
     where TEntity : class, IEntity, new()
    {
        List<TEntity> GetAll(RepositoryParameters<TEntity> parameters = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includeList);
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
    }
}
