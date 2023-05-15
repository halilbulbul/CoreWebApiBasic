using CoreWebApi.Business.Abstract;
using CoreWebApi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductBs _productBs;
        public ProductsController(IProductBs productBs)
        {
            _productBs = productBs;
        }

        [HttpGet("GetAll")]
        public List<Product> GetAll()
        {
            List<Product> productList = _productBs.GetAll();
            return productList;
        }
    }
}
