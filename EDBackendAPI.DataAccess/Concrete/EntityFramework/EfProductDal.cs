using EDBackendAPI.Core.DataAccess.EntityFramework;
using EDBackendAPI.DataAccess.Abstract;
using EDBackendAPI.DataAccess.Concrete.EntityFramework.Contexts;
using EDBackendAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EDBackendAPI.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}
