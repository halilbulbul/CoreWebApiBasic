using CoreWebApi.DataAccess.Abstract;
using CoreWebApi.DataAccess.Concrete.EntityFramework.Context;
using CoreWebApi.Infrastructure.DataAccess.Concrete.EntityFramework;
using CoreWebApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.DataAccess.Concrete.EntityFramework
{
    public class CategoryRepositoryEf : BaseRepositoryEf<Category, DatabaseContext>, ICategoryRepository
    {
    }
}
