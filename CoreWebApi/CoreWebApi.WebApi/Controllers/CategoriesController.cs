using CoreWebApi.Business.Abstract;
using CoreWebApi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryBs _categoryBs;

        public CategoriesController(ICategoryBs categoryBs)
        {
            _categoryBs = categoryBs;
        }

        [HttpGet("GetAll")]
        public List<Category> GetAll()
        {
            List<Category> categoryList = _categoryBs.GetAll();
            return categoryList;
        }

        [HttpGet("GetById")]
        public Category GetById(int Id)
        {
            Category category = _categoryBs.Get(x => x.Id == Id);
            return category;
        }
    }
}
