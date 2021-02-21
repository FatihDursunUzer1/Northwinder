using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.DatabaseContext;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal: EfRepositoryBase<Product, NorthwindDbContext>, IProductDal
    {
    }
}
