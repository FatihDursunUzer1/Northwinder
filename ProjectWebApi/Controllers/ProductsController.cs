using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductDal _productDal;

        public ProductsController()
        {
            _productDal = new EfProductDal();
        }
        [HttpDelete]
        public void Delete(Product product)
        {
            _productDal.Delete(product);

        }
        [HttpGet]
        public List<Product> Get()
        {
            return _productDal.GetAll();
        }
    }
}
