using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları
            //yetki kontrolu
            return _productDal.GetAll();
        }

        public List<Product> GetByCategoryId(int id)
        {
            return _productDal.GetAll(x => x.CategoryId == id);
        }

        public List<Product> GetByUniPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(x => x.UnitPrice >= min && x.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
