using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal categoryService;

        public CategoryManager(ICategoryDal categoryService)
        {
            this.categoryService = categoryService;
        }
        public IDataResult<List<Category>> GetAll()
        {
            var data = categoryService.GetAll();
            return new SuccessDataResult<List<Category>>("Kategori Listeleme başarılı",data);
        }

        public IDataResult<Category> GetCategoryById(int id)
        {
            var data = categoryService.Get(c => c.CategoryID == id);
            return new SuccessDataResult<Category>("Kategori getirme işlemi başarılı",data);
        }
    }
}
