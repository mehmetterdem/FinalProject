using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
           {
               new Product{ProductID=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
               new Product{ProductID=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
               new Product{ProductID=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
               new Product{ProductID=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
               new Product{ProductID=1,CategoryId=1,ProductName="Mouse",UnitPrice=85,UnitsInStock=1},
           };
            
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.Where(x => x.ProductID == product.ProductID).FirstOrDefault();
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(x => x.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product updateToProduct = _products.FirstOrDefault(x => x.ProductID == product.ProductID);
            updateToProduct.ProductName = product.ProductName;
            updateToProduct.CategoryId = product.CategoryId;
            updateToProduct.UnitsInStock = product.UnitsInStock;
            updateToProduct.UnitPrice = product.UnitPrice;
        }
    }
}
