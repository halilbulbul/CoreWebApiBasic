using CoreWebApi.Business.Abstract;
using CoreWebApi.DataAccess.Abstract;
using CoreWebApi.Infrastructure.Business.Concrete;
using CoreWebApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.Business.Concrete
{
    public class CategoryBusiness : BusinessBase<Category>, ICategoryBs
    {

        public CategoryBusiness(ICategoryRepository repo) : base(repo)
        {
        }
    }
}
