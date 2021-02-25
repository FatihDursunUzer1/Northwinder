using Business.Abstract;
using Business.Constants;
using Business.Validation.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingCorners.Validation;
using Core.Results.Abstract;
using Core.Results.Concrete;
using Core.Utilities.Business;
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
        private ICategoryService _categoryService;

        public ProductManager(IProductDal productDal,ICategoryService categoryService)
        {
            _productDal = productDal;
            _categoryService = categoryService;
        }
        [ValidationAspect(typeof(ProductValidator))]
        public IDataResult<Product> AddProduct(Product product)
        {
            var result = BusinessRules.Run(CheckIfProductNameExists(product.ProductName),CheckIfCategoryLimitExceded());
            if (!result.Success)
                return new ErrorDataResult<Product>(result.Message);
            else
                return new SuccessDataResult<Product>(Message.ProductAdded, product);
        }

        public IDataResult<List<Product>> GetAllProduct()
        {

            return new SuccessDataResult<List<Product>>(Message.ProductsListed, _productDal.GetAll());

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
                /*var data = _productDal.Get(p => p.ProductID == id);
                ValidationTool.Validate(new ProductValidator(), data);*/

                return new SuccessDataResult<Product>(Message.ProductBroughtById, _productDal.Get(p => p.ProductID == id));
        }

        private IResult CheckIfProductNameExists(string name)
        {
            if(_productDal.Get(p=>p.ProductName==name)!=null)
            {
                return new ErrorResult(Message.ProductNameAlreadyExists);
            }
            return new SuccessResult(Message.ProductAdded);
        }
        private IResult CheckIfCategoryLimitExceded()
        {
            var result = _categoryService.GetAll();
            if (result.data.Count > 5)
                return new ErrorResult("İşlem başarısız");
            return new SuccessResult("İşlem başarılı");
        }

    }
}
