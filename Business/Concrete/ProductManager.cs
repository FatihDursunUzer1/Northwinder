using Business.Abstract;
using Business.Constants;
using Core.Results.Abstract;
using Core.Results.Concrete;
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
            _productDal = new EfProductDal(); //Dependency Injection sorunu.
        }
        public IDataResult<Product> AddProduct(Product product)
        {
            try
            {
                return new SuccessDataResult<Product>(Message.ProductAdded, product);
            }
            catch(Exception)
            {
                return new ErrorDataResult<Product>("Error");
            }
        }

        public IDataResult<List<Product>> GetAllProduct()
        {
            var data = _productDal.GetAll();
            try
            {
                return new SuccessDataResult<List<Product>>(Message.ProductsListed, data);
            }
            catch (Exception)
            {

                return new ErrorDataResult<List<Product>>("Error");
            }
        }

        public IDataResult<List<Product>> GetAllProductByCategoryId(int categoryId)
        {
            var data = _productDal.GetAll(p => p.CategoryID == categoryId);
            try 
            {
                return new SuccessDataResult<List<Product>>(Message.ProductsListedByCategoryId,data);
            }
            catch (Exception)
            {
                return new ErrorDataResult<List<Product>>("Error");
            }
           
        }

        public IDataResult<Product> GetProductById(int id)
        {
            try
            {
                return new SuccessDataResult<Product>(Message.ProductBroughtById, _productDal.Get(p => p.ProductID == id));
            }
            catch
            {
                return new ErrorDataResult<Product>("Error");
            }
        }
    }
}
