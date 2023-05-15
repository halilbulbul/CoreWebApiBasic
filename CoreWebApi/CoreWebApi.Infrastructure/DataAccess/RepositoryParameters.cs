using CoreWebApi.Infrastructure.Model.Abstract;
using CoreWebApi.Infrastructure.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.Infrastructure.DataAccess
{
    public class RepositoryParameters<TEntity>
        where TEntity : class, IEntity, new()
    {
        public Expression<Func<TEntity, bool>> filter { get; set; } = null;
        public int take { get; set; } = 0;
        public int skip { get; set; } = 0;
        public string[] includeList { get; set; } = null;
        public Expression<Func<TEntity, object>> orderBy { get; set; } = null;
        public SortDirection? sortDirection { get; set; } = null;

    }
}
