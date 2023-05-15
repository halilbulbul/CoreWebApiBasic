using CoreWebApi.Infrastructure.DataAccess.Abstract;
using CoreWebApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.DataAccess.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
    }
}
