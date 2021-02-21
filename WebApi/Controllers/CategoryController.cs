using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryDal _CategoryDal;
        public CategoryController()
        {
            _CategoryDal = new EfCategoryDal();
        }
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _CategoryDal.Get(c => c.CategoryID == id);
        }
        [HttpGet]
        public List<Category> Get()
        {
            return _CategoryDal.GetAll();
        }

        [HttpPost]
        public Category Add(Category category)
        {
            return _CategoryDal.Add(category);
        }
        [HttpDelete]
        public void Delete(Category category)
        {
            _CategoryDal.Delete(category);
        }
    }
}
