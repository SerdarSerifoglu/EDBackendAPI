using EDBackendAPI.Business.Abstract;
using EDBackendAPI.DataAccess.Abstract;
using EDBackendAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EDBackendAPI.Business.Concrete
{
    public class ProductService : IProductService
    {
        private IProductDal _productDal;
        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Task<Product> GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public Task<List<Product>> GetList()
        {
            return _productDal.GetList();
        }

        public Task<List<Product>> GetListByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
