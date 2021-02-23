using Core.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        public IDataResult<Product> GetProductById(int id);
        public IDataResult<List<Product>> GetAllProduct();
        public IDataResult<List<Product>> GetAllProductByCategoryId(int categoryId);
        public IDataResult<Product> AddProduct(Product product);
    }
}
