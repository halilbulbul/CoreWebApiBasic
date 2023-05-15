using CoreWebApi.Infrastructure.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebApi.Models.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
