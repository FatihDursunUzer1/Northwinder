using Core.Results.Abstract;
using Core.Results.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public IDataResult<Category> GetCategoryById(int id);
        public IDataResult<List<Category>> GetAll();

    }
}
