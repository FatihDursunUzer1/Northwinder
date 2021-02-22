using Business.Abstract;
using Business.Concrete;
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
        private IProductService _productService;

        public ProductsController()
        {
            _productService = new ProductManager();
        }
        /*[HttpDelete]
        public void Delete(Product product)
        {
            

        }*/
        [HttpGet]
        public List<Product> Get()
        {
            return _productService.GetAllProduct();
        }
        [HttpPost]
        public Product Post(Product product)
        {
            return _productService.AddProduct(product);
        }
    }
}
