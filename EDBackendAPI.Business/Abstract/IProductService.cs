using EDBackendAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EDBackendAPI.Business.Abstract
{
    public interface IProductService
    {
        Task<Product> GetById(int productId);
        Task<List<Product>> GetList();
        Task<List<Product>> GetListByCategory(int categoryId);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
}
