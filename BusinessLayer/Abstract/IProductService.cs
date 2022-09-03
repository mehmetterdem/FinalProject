using Core.Utilities.Result;
using Core.Utilities.Results;
using EntityLayer.Concrete;
using EntityLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        IResult Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        IDataResult<Product> GetById(int id);
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetByCategoryId(int id);
        IDataResult<List<Product>> GetByUniPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();

    }
}
