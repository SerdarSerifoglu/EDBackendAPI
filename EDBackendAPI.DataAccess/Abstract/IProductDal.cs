using EDBackendAPI.Core.DataAccess;
using EDBackendAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
