using EDBackendAPI.Business.Abstract;
using EDBackendAPI.Core.Utilities.Results;
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
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult("Ürün başarıyla eklendi");
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult("Ürün başarıyla silindi");
        }

        public IDataResult<Task<Product>> GetById(int productId)
        {
            return new SuccessDataResult<Task<Product>>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<Task<List<Product>>> GetList()
        {
            return new SuccessDataResult<Task<List<Product>>>(_productDal.GetList());
        }

        public IDataResult<Task<List<Product>>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<Task<List<Product>>>(_productDal.GetList(p => p.CategoryId == categoryId));
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult("Ürün başarıyla güncellendi");
        }
    }
}
