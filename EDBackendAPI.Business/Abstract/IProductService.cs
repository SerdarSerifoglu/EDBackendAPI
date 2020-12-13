using EDBackendAPI.Core.Utilities.Results;
using EDBackendAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EDBackendAPI.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Task<Product>> GetById(int productId);
        IDataResult<Task<List<Product>>> GetList();
        IDataResult<Task<List<Product>>> GetListByCategory(int categoryId);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
    }
}
