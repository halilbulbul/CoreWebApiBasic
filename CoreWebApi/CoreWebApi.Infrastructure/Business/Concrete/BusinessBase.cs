using CoreWebApi.Infrastructure.Business.Abstract;
using CoreWebApi.Infrastructure.DataAccess;
using CoreWebApi.Infrastructure.DataAccess.Abstract;
using CoreWebApi.Infrastructure.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.Infrastructure.Business.Concrete
{
    public class BusinessBase<TEntity> : IBusinessBase<TEntity>
    where TEntity : class, IEntity, new()
    {
        IEntityRepository<TEntity> _repo;
        public BusinessBase(IEntityRepository<TEntity> repo)
        {
            _repo = repo;
        }

        public bool Add(TEntity entity)
        {
            return _repo.Add(entity);
        }

        public bool Delete(TEntity entity)
        {
            return _repo.Delete(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includeList)
        {
            return _repo.Get(filter, includeList);
        }

        public List<TEntity> GetAll(RepositoryParameters<TEntity> parameters = null)
        {
            return _repo.GetAll(parameters);
        }

        public bool Update(TEntity entity)
        {
            return _repo.Update(entity);
        }
    }

}
