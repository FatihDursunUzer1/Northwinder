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

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        /*[HttpDelete]
        public void Delete(Product product)
        {
            

        }*/

        /// <summary>
        /// Sonuç olarak tüm ürünleri return eder
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var data = _productService.GetAllProduct();
            if (data.Success)
                return Ok(data);
            return BadRequest(data);
        }
        //[HttpGet("{id}")]

        /// <summary>
        /// Sonuç olarak belirtilen id ye ait ürünü return eder
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("byproductid")]//byproductid?id=x seklinde cagirildiginda bize dataları getirebilir.
        public IActionResult Get(int id)
        {
            var data = _productService.GetProductById(id);
            if (data.Success)
                return Ok(data);
            return BadRequest(data);
        }

        /// <summary>
        /// Sonuç olarak belirtilen categoryId ye sahip olan ürünlerin tamamını return eder
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        //[HttpGet("{categoryId}")]
        [HttpGet("bycategoryid")] //bycategoryid?categoryId=x seklinde cagirildiginda bize dataları getirebilir.
        public IActionResult GetByCategory(int categoryId)
        {
            var data = _productService.GetAllProductByCategoryId(categoryId);
            if (data.Success)
                return Ok(data);
            return BadRequest(data);
        }

        /// <summary>
        /// Yeni bir ürün eklenmesini sağlar.
        /// Veritabanına eklenen bu yeni öğeyi return eder.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        
        [HttpPost]
        public IActionResult Post(Product product)
        {
            var data= _productService.AddProduct(product);
            if (data.Success)
                return Ok(data);
            return BadRequest(data);
        }
    }
}
