using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager()
        {
            _productDal = new EfProductDal();
        }
        public Product AddProduct(Product product)
        {
            return _productDal.Add(product);
        }

        public List<Product> GetAllProduct()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllProductByCategoryId(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryID == categoryId);
        }

        public Product GetProductById(int id)
        {
            return _productDal.Get(p => p.ProductID == id);
        }
    }
}
