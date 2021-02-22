using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        public Product GetProductById(int id);
        public List<Product> GetAllProduct();
        public List<Product> GetAllProductByCategoryId(int categoryId);
        public Product AddProduct(Product product);
    }
}
